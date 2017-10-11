/**
 * This file is based on the example on the MSDN page for FileSystemWatcher class
 **/

using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Permissions;
using Assignment2.Models;

namespace Assignment2 {

    public delegate void FileEventAction(FileEvent f);

    public class WatcherService {

        private FileSystemWatcher watcher;
        private ILoggerService logger;
        public event FileEventAction OnFilesystemChange;

        public bool IsRunning { get; set; }
        public bool InitCompleted { get; set; }
        public string MonitorPath { get; set; }
        public string LogPath { get; set; }

        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        public WatcherService() {
            this.IsRunning = false;
            this.InitCompleted = false;
            this.LogPath = @"C:\Users\Ethan Holman\appLog.log";
            this.MonitorPath = @"C:\Users\Ethan Holman\temp";
        }

        public void Init() {

            // Create a new FileSystemWatcher and set its properties
            watcher = new FileSystemWatcher();
            watcher.Path = MonitorPath;
            watcher.IncludeSubdirectories = true;
            watcher.Filter = "*.txt";
            watcher.NotifyFilter = NotifyFilters.LastAccess |
                                    NotifyFilters.LastWrite |
                                    NotifyFilters.FileName |
                                    NotifyFilters.DirectoryName;

            watcher.Changed += new FileSystemEventHandler((object s, FileSystemEventArgs e) => LogEvent(e, FileEventTypes.FileModified, ObjectTypes.File));
            watcher.Created += new FileSystemEventHandler((object s, FileSystemEventArgs e) => LogEvent(e, FileEventTypes.FileCreated, ObjectTypes.File));
            watcher.Deleted += new FileSystemEventHandler((object s, FileSystemEventArgs e) => LogEvent(e, FileEventTypes.FileDeleted, ObjectTypes.File));
            watcher.Renamed += new RenamedEventHandler((object src, RenamedEventArgs e) => LogEvent(e, FileEventTypes.FileRenamed, ObjectTypes.File));

            // Init a logging service
            this.logger = new FileLoggerService(LogPath);

            InitCompleted = true;
        }

        public void Start() {
            if(!InitCompleted) this.Init();
            watcher.EnableRaisingEvents = true;
        }

        public void Stop() {
            watcher.EnableRaisingEvents = false;
        }

        private void LogEvent(FileSystemEventArgs e, FileEventTypes fe, ObjectTypes ot) {
            var fileEvent = new FileEvent(e.Name, e.FullPath, fe, DateTime.Now, ot);
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