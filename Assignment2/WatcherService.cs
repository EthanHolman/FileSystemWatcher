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
        private List<string> _events;
        public List<string> Events { get { return this._events; } }

        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        public WatcherService(string watchPath, ILoggerService logger) {
            this._path = watchPath;
            this._logger = logger;
            this._events = new List<string>();

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
            _watcher.Changed += new FileSystemEventHandler(OnModified);
            _watcher.Created += new FileSystemEventHandler(OnModified);
            _watcher.Deleted += new FileSystemEventHandler(OnModified);
            _watcher.Renamed += new RenamedEventHandler(OnRenamed);
        }

        public void Start() {
            _watcher.EnableRaisingEvents = true;
        }

        public void Stop() {
            _watcher.EnableRaisingEvents = false;
        }

        private void OnModified(object source, FileSystemEventArgs e) {
            FileEvent f = new FileEvent()
            _logger.LogFileEvent(FileEvents.FileModified, ObjectType.File, "File: " + e.FullPath + " " + e.ChangeType);
            _events.Add("File: " + e.FullPath + " " + e.ChangeType);
        }

        private void OnRenamed(object source, RenamedEventArgs e) {
            _logger.LogFileEvent(FileEvents.FileRenamed, ObjectType.File, "File: " + e.OldFullPath + " renamed to " + e.FullPath);
            _events.Add("File: " + e.OldFullPath + " renamed to " + e.FullPath);
        }
    }

}