using System;
using System.Text;
using Assignment2.Models;
using System.IO;
using System.Collections.Generic;

namespace Assignment2.Services {
    public class FileLoggerService : ILoggerService {

        private StreamWriter fout;
        public string Path { get; set; }
        public string Filename { get; set; }
        public FileLoggerService(string path, string filename) {
            this.Path = path;
            this.Filename = filename;
            this.fout = new StreamWriter(path + @"\" + filename, true);
            fout.WriteLine("*** File System Watcher Beginning ***");
            fout.WriteLine("*** " + DateTime.Now + " ***");
            fout.WriteLine("*** Watching Directory: " + path + " ***");
            fout.WriteLine();
        }
        
        public void LogFileEvent(FileEvent f) {
            Console.WriteLine(f.ToString());
            fout.WriteLine(f.ToString());
            fout.Flush();
        }

        bool ILoggerService.LogFileEvent(FileEvent f) {
            throw new NotImplementedException();
        }

        public bool LogFileEvents(List<FileEvent> data) {
            throw new NotImplementedException();
        }

        public List<FileEvent> GetFileEvents(List<string> extensions) {
            throw new NotImplementedException();
        }

        public List<FileEvent> GetFileEvents(DateTime start, DateTime end, List<string> extensions) {
            throw new NotImplementedException();
        }

        public void DeleteFileEvent(FileEvent f) {
            throw new NotImplementedException();
        }

        public List<FileEvent> GetFileEvents() {
            throw new NotImplementedException();
        }

        public bool EraseData() {
            throw new NotImplementedException();
        }
    }
}
