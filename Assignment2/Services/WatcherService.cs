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

        #region Property Backing Fields

        private string _MonitorPath;
        private bool _MonitorSubDirectories;
        private bool _LogToSqlite;
        private bool _LogToFile;

        #endregion

        private FileSystemWatcher watcher;
        private List<ILoggerService> loggingServices;
        public event FileEventAction OnFilesystemChange;
        

        public bool IsRunning { get; set; }
        public bool InitCompleted { get; set; }
        public string MonitorPath { get => _MonitorPath; set { _MonitorPath = value ; InitCompleted = false; } }
        public bool MonitorSubDirectories { get => _MonitorSubDirectories; set { _MonitorSubDirectories = value; InitCompleted = false; } }
        public List<FileEvent> Events { get; set; }
        public bool LiveLogging { get; set; }
        public bool LogToSqlite { get => _LogToSqlite; set { _LogToSqlite = value; RefreshLoggers(); } }
        public string SqliteTableName { get; set; }
        public string SqliteFileName { get; set; }
        public List<string> ExtensionsToWatch { get; set; }
       
        
        /* Logging to File Properties */
        public bool LogToFile { get => _LogToFile; set { _LogToFile = value; RefreshLoggers(); } }
        public string LogPath { get; set; }
        public string LogFileName { get; set; }


        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        public WatcherService() {
            this.IsRunning = false;
            this.InitCompleted = false;

            // Set up some default paths and names
            this.LogPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            this.MonitorPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this.LogFileName = "fswatcher.log";
            this.MonitorSubDirectories = true;
            this.Events = new List<FileEvent>();
            this.LiveLogging = false;
            this.loggingServices = new List<ILoggerService>();
            this.SqliteTableName = "fs_events";
            this.SqliteFileName = ".";
            this.ExtensionsToWatch = new List<string>();
        }

        /* Init Function should only be called AFTER ALL PREFERENCES have been set! */
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

            RefreshLoggers();

            InitCompleted = true;
        }

        private void RefreshLoggers() {
            loggingServices.Clear(); // Remove all logging services that pre-exist

            // File Logger
            if(LogToFile) {
                ILoggerService fileLogger = new FileLoggerService(LogPath, LogFileName);
                if(fileLogger != null) loggingServices.Add(fileLogger);
            }

            // SQLite Logger
            if(LogToSqlite) {
                ILoggerService SQLiteLogger = new SQLiteLoggerService(SqliteFileName, SqliteTableName);
                if(SQLiteLogger != null) loggingServices.Add(SQLiteLogger);
            }

        }

        public void Start() {
            if(!InitCompleted) this.Init();
            watcher.EnableRaisingEvents = true;
            IsRunning = true;
        }

        public void Stop() {
            watcher.EnableRaisingEvents = false;
            IsRunning = false;
        }

        private void NewEvent(FileSystemEventArgs e, FileEventTypes fe) {
            string name = e.Name.Split('\\')[e.Name.Split('\\').Length - 1];
            // Skip logging if the event involves the file we're logging TO
            if(name == LogFileName) return; 

            ObjectTypes objectType;
            try {
                 objectType = (File.GetAttributes(e.FullPath)).HasFlag(FileAttributes.Directory) ? ObjectTypes.Directory : ObjectTypes.File;
            } catch { objectType = ObjectTypes.File; }

            var fileEvent = new FileEvent(name, e.FullPath, fe, DateTime.Now, objectType);
            
            // Only process fileEvent if it's extension matches the filter, or no filter is defined
            if(ExtensionsToWatch.Contains(fileEvent.Extension) || ExtensionsToWatch.Count == 0){
                this.Events.Add(fileEvent);
                this.EmitEvent(fileEvent);

                // If user selected LiveLogging, then log this new FileEvent to all registered logging services
                if(LiveLogging) {
                    foreach(ILoggerService cur in loggingServices) {
                        cur.LogFileEvent(fileEvent);
                    }
                }
            }
        }

        public bool LogAllEventsToBackend() {
            bool toReturn = true;
            foreach(ILoggerService cur in loggingServices) {
                if(!cur.LogFileEvents(this.Events)) toReturn = false;
            }
            
            return toReturn;
        }

        public void AddChangedEventHandler(FileEventAction e) {
            this.OnFilesystemChange += e;
        }

        private void EmitEvent(FileEvent f) {
            if(this.OnFilesystemChange != null) {
                OnFilesystemChange(f);
            }
        }

        public ILoggerService GetLoggerService() {
            /*ILoggerService toReturn = null;

            foreach(ILoggerService svc in loggingServices) {
                if(svc is SQLiteLoggerService) toReturn = svc;
            }

            return toReturn;*/
            return new SQLiteLoggerService(SqliteFileName, SqliteTableName);
        }

    }
}