/**
 * This file is based on the example on the MSDN page for FileSystemWatcher class
 **/

using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Permissions;
using Assignment2.Models;

namespace Assignment2.Services {

    public delegate void FileEventAction(FileEvent f);

    public class WatcherService {

        private FileSystemWatcher watcher;
        private ILoggerService logger;
        public event FileEventAction OnFilesystemChange;

        public bool IsRunning { get; set; }
        public bool InitCompleted { get; set; }
        public string MonitorPath { get; set; }
        public string LogPath { get; set; }
        public string LogFileName { get; set; }
        public bool MonitorSubDirectories { get; set; }

        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        public WatcherService() {
            this.IsRunning = false;
            this.InitCompleted = false;

            // Set up some default paths and names
            this.LogPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            this.MonitorPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this.LogFileName = "fswatcher.log";
            this.MonitorSubDirectories = true;
        }

        public void Init() {

            // Create a new FileSystemWatcher and set its properties
            watcher = new FileSystemWatcher();
            watcher.Path = MonitorPath;
            watcher.IncludeSubdirectories = this.MonitorSubDirectories;
            watcher.Filter = "*.*";
            watcher.NotifyFilter = NotifyFilters.LastAccess |
                                   NotifyFilters.LastWrite |
                                   NotifyFilters.FileName |
                                   NotifyFilters.DirectoryName;

            watcher.Changed += new FileSystemEventHandler((object s, FileSystemEventArgs e) => LogEvent(e, FileEventTypes.Modified));
            watcher.Created += new FileSystemEventHandler((object s, FileSystemEventArgs e) => LogEvent(e, FileEventTypes.Created));
            watcher.Deleted += new FileSystemEventHandler((object s, FileSystemEventArgs e) => LogEvent(e, FileEventTypes.Deleted));
            watcher.Renamed += new RenamedEventHandler((object s, RenamedEventArgs e) => LogEvent(e, FileEventTypes.Renamed));

            // Init a logging service (this could be changed out for SQL)
            this.logger = new FileLoggerService(LogPath, LogFileName);

            InitCompleted = true;
        }

        public void Start() {
            if(!InitCompleted) this.Init();
            watcher.EnableRaisingEvents = true;
        }

        public void Stop() {
            watcher.EnableRaisingEvents = false;
        }

        private void LogEvent(FileSystemEventArgs e, FileEventTypes fe) {
            string name = e.Name.Split('\\')[e.Name.Split('\\').Length - 1];
            // Skip logging if the event involves the file we're logging TO
            if(name == LogFileName) return; 

            ObjectTypes objectType;
            try {
                 objectType = (File.GetAttributes(e.FullPath)).HasFlag(FileAttributes.Directory) ? ObjectTypes.Directory : ObjectTypes.File;
            } catch(Exception ex) {
                objectType = ObjectTypes.File;
            }
            var fileEvent = new FileEvent(name, e.FullPath, fe, DateTime.Now, objectType);
            logger.LogFileEvent(fileEvent);
            this.EmitEvent(fileEvent);
        }

        public void AddChangedEventHandler(FileEventAction e) {
            this.OnFilesystemChange += e;
        }

        private void EmitEvent(FileEvent f) {
            if(this.OnFilesystemChange != null) {
                OnFilesystemChange(f);
            }
        }

    }
}