/**
 * This file is based on the example on the MSDN page for FileSystemWatcher class
 **/

using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Permissions;
using Assignment2.Models;

namespace Assignment2 {
    public class WatcherService {

        private FileSystemWatcher _watcher;
        private string _path;
        private ILoggerService _logger;
        private List<FileEvent> _events;
        public List<FileEvent> Events { get { return this._events; } }
        public delegate void FileEventAction(FileEvent f);
        public event FileEventAction OnFilesystemChange;

        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        public WatcherService(string watchPath, ILoggerService logger) {
            this._path = watchPath;
            this._logger = logger;
            this._events = new List<FileEvent>();

            // Create a new FileSystemWatcher and set its properties.
            _watcher = new FileSystemWatcher();
            _watcher.Path = this._path;

            /* Watch for changes in LastAccess and LastWrite times, and
               the renaming of files or directories. */
            _watcher.NotifyFilter = NotifyFilters.LastAccess |
                                    NotifyFilters.LastWrite |
                                    NotifyFilters.FileName |
                                    NotifyFilters.DirectoryName;

            _watcher.IncludeSubdirectories = true;

            // Only watch text files.
            _watcher.Filter = "*.txt";

            // Add event handlers.
            _watcher.Changed += new FileSystemEventHandler((object s, FileSystemEventArgs e) => this.LogEvent(s, e, FileEvents.FileModified, ObjectType.File));
            _watcher.Created += new FileSystemEventHandler((object s, FileSystemEventArgs e) => this.LogEvent(s, e, FileEvents.FileCreated, ObjectType.File));
            _watcher.Deleted += new FileSystemEventHandler((object s, FileSystemEventArgs e) => this.LogEvent(s, e, FileEvents.FileDeleted, ObjectType.File));
            _watcher.Renamed += new RenamedEventHandler((object src, RenamedEventArgs e) => {
                FileEvent f = new FileEvent(e.Name, e.FullPath, FileEvents.FileRenamed, DateTime.Now, ObjectType.File);
                _logger.LogFileEvent(f);
                _events.Add(f);
            });
        }

        public void addChangedHandler(FileSystemEventHandler e) {
            _watcher.Changed += e;
        }

        public void Start() {
            _watcher.EnableRaisingEvents = true;
        }

        public void Stop() {
            _watcher.EnableRaisingEvents = false;
        }

        private void LogEvent(object src, FileSystemEventArgs e, FileEvents fe, ObjectType ot) {
            var fileEvent = new FileEvent(e.Name, e.FullPath, fe, DateTime.Now, ot);
            _logger.LogFileEvent(fileEvent);
            _events.Add(fileEvent);
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