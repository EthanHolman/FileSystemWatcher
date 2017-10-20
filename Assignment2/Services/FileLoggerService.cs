using System;
using System.Text;
using Assignment2.Models;
using System.IO;

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

        public FileEvent[] GetFileEvents(DateTime start, DateTime end, string[] extensions) {
            throw new NotImplementedException();
        }

        public void DeleteFileEvent(FileEvent f) {
            throw new NotImplementedException();
        }
    }
}
