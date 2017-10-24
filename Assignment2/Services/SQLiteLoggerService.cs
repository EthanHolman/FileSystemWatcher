using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2.Models;
using System.Data.SQLite;

namespace Assignment2.Services {
    class SQLiteLoggerService : ILoggerService {

        private SQLiteConnection sql;
        private string tableName;

        public SQLiteLoggerService(string pathToDbFile, string tableName) {
            this.sql = new SQLiteConnection("Data Source=FileSystemWatcher.db;Version=3;New=True;Compress=True");
            this.sql.Open();
            this.tableName = tableName;

            // TODO add error handling here...
            using(SQLiteCommand cmd = this.sql.CreateCommand()) {
                cmd.CommandText = "CREATE TABLE IF NOT EXISTS " + tableName + " (Id varchar(128) primary key, FileName varchar(128), FilePath varchar(256), EventType integer, Timestamp datetime, ObjType integer, Extension varchar(15));";
                cmd.ExecuteNonQuery();
            }
            
        }

        public void DeleteFileEvent(FileEvent f) {
            throw new NotImplementedException();
        }

        public List<FileEvent> GetFileEvents(List<string> extensions) {
            return GetFileEvents(DateTime.MinValue, DateTime.MinValue, extensions);
        }

        public List<FileEvent> GetFileEvents(DateTime start, DateTime end, List<string> extensions) {
            List<FileEvent> toReturn = new List<FileEvent>();
            string extStr = string.Join(",", extensions.Select(x => "'" + x.ToString() + "'").ToArray());

            try {
                using(SQLiteCommand cmd = this.sql.CreateCommand()) {
                    cmd.CommandText = $"SELECT * FROM {tableName}";
                    if(extensions.Count > 0) cmd.CommandText += $" WHERE Extension IN ({extStr})";
                    using(SQLiteDataReader reader = cmd.ExecuteReader()) {
                        while(reader.Read()) {
                            toReturn.Add(new FileEvent(
                                reader["FileName"].ToString(),
                                reader["FilePath"].ToString(),
                                (FileEventTypes) Enum.Parse(typeof(FileEventTypes), (reader["EventType"]).ToString()),
                                DateTime.Parse(reader["Timestamp"].ToString()),
                                (ObjectTypes) Enum.Parse(typeof(ObjectTypes), (reader["ObjType"]).ToString())
                            ));
                        }
                    }
                }
            } catch {
                return null;
            }

            return toReturn;
        }

        public List<FileEvent> GetFileEvents() {
            List<string> temp = new List<string>();
            temp.Add("*");
            return this.GetFileEvents(temp);
        }

        public bool LogFileEvent(FileEvent f) {
            List<FileEvent> temp = new List<FileEvent>();
            temp.Add(f);
            return this.LogFileEvents(temp);
        }

        public bool LogFileEvents(List<FileEvent> data) {
            try {
                using(SQLiteCommand cmd = this.sql.CreateCommand()) {
                
                    cmd.CommandText = @"INSERT INTO fs_events(Id, FileName, FilePath, EventType, Timestamp, ObjType, Extension) VALUES (@Id, @FileName, @FilePath, @EventType, @Timestamp, @ObjType, @Extension)";
                    cmd.Prepare();

                    foreach(FileEvent item in data) {
                        // Skip files that have already been logged (if liveLogging is on)
                        if(item.HasBeenSavedToLog) continue;

                        cmd.Parameters.AddWithValue("@Id", item.Id.ToString());
                        cmd.Parameters.AddWithValue("@FileName", item.FileName);
                        cmd.Parameters.AddWithValue("@FilePath", item.FilePath);
                        cmd.Parameters.AddWithValue("@EventType", item.EventType);
                        cmd.Parameters.AddWithValue("@Timestamp", item.Timestamp);
                        cmd.Parameters.AddWithValue("@ObjType", item.ObjType);
                        cmd.Parameters.AddWithValue("@Extension", item.Extension);

                        cmd.ExecuteNonQuery();
                        item.HasBeenSavedToLog = true;
                    }
                }
            } catch {
                return false;
            }

            return true;
        }

        public bool EraseData() {
            try {
                using(SQLiteCommand cmd = this.sql.CreateCommand()) {
                    cmd.CommandText = $"DELETE FROM {tableName};";
                    cmd.ExecuteNonQuery();
                }
            } catch {
                return false;
            }

            return true;
        }
    }
}
