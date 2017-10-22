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
        public List<FileEvent> LoggedEvents { get; set; }
        public bool LiveLogging { get; set; }

        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        public WatcherService() {
            this.IsRunning = false;
            this.InitCompleted = false;

            // Set up some default paths and names
            this.LogPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            this.MonitorPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this.LogFileName = "fswatcher.log";
            this.MonitorSubDirectories = true;
            this.LoggedEvents = new List<FileEvent>();
            this.LiveLogging = false;
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

            watcher.Changed += new FileSystemEventHandler((object s, FileSystemEventArgs e) => NewEvent(e, FileEventTypes.Modified));
            watcher.Created += new FileSystemEventHandler((object s, FileSystemEventArgs e) => NewEvent(e, FileEventTypes.Created));
            watcher.Deleted += new FileSystemEventHandler((object s, FileSystemEventArgs e) => NewEvent(e, FileEventTypes.Deleted));
            watcher.Renamed += new RenamedEventHandler((object s, RenamedEventArgs e) => NewEvent(e, FileEventTypes.Renamed));

            // File Logger
            //this.logger = new FileLoggerService(LogPath, LogFileName);

            // SQLite Logger
            this.logger = new SQLiteLoggerService(".", "fs_events");
            
            InitCompleted = true;
        }

        public void Start() {
            if(!InitCompleted) this.Init();
            watcher.EnableRaisingEvents = true;
        }

        public void Stop() {
            watcher.EnableRaisingEvents = false;
        }

        private void NewEvent(FileSystemEventArgs e, FileEventTypes fe) {
            string name = e.Name.Split('\\')[e.Name.Split('\\').Length - 1];
            // Skip logging if the event involves the file we're logging TO
            if(name == LogFileName) return; 

            ObjectTypes objectType;
            try {
                 objectType = (File.GetAttributes(e.FullPath)).HasFlag(FileAttributes.Directory) ? ObjectTypes.Directory : ObjectTypes.File;
            } catch {
                objectType = ObjectTypes.File;
            }

            var fileEvent = new FileEvent(name, e.FullPath, fe, DateTime.Now, objectType);
            this.LoggedEvents.Add(fileEvent);
            this.EmitEvent(fileEvent);
        }

        public bool LogAllEventsToBackend() {
            try {
                this.logger.LogFileEvents(this.LoggedEvents);
            } catch {
                return false;
            }

            return true;
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