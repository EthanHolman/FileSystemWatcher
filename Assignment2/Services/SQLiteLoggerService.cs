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

        public SQLiteLoggerService(string pathToDbFile, string tableName) {
            this.sql = new SQLiteConnection("Data Source=FileSystemWatcher.db;Version=3;New=True;Compress=True");
            this.sql.Open();

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
            throw new NotImplementedException();
        }

        public List<FileEvent> GetFileEvents(DateTime start, DateTime end, List<string> extensions) {
            throw new NotImplementedException();
        }

        public void LogFileEvent(FileEvent f) {
            
        }

        public void LogFileEvents(List<FileEvent> data) {
            using(SQLiteCommand cmd = this.sql.CreateCommand()) {
                
                cmd.CommandText = @"INSERT INTO fs_events(Id, FileName, FilePath, EventType, Timestamp, ObjType, Extension) VALUES (@Id, @FileName, @FilePath, @EventType, @Timestamp, @ObjType, @Extension)";
                cmd.Prepare();

                foreach(FileEvent item in data) {
                    cmd.Parameters.AddWithValue("@Id", item.Id.ToString());
                    cmd.Parameters.AddWithValue("@FileName", item.FileName);
                    cmd.Parameters.AddWithValue("@FilePath", item.FilePath);
                    cmd.Parameters.AddWithValue("@EventType", item.EventType);
                    cmd.Parameters.AddWithValue("@Timestamp", item.Timestamp);
                    cmd.Parameters.AddWithValue("@ObjType", item.ObjType);
                    cmd.Parameters.AddWithValue("@Extension", item.Extension);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
