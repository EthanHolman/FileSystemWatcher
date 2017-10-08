using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2.Models;

namespace Assignment2 {
    public class FileLoggerService : ILoggerService {
        public string Path { get; set; }
        public FileLoggerService(string path) {
            this.Path = path;
        }
        public void LogFileEvent(FileEvents eventType, ObjectType objectType, string logText) {
            Console.Write(logText);
        }
    }
}
