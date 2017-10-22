using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2.Models;

namespace Assignment2.Services {
    public interface ILoggerService {
        void LogFileEvent(FileEvent f);
        void LogFileEvents(List<FileEvent> data);
        List<FileEvent> GetFileEvents(List<string> extensions);
        List<FileEvent> GetFileEvents(DateTime start, DateTime end, List<string> extensions);
        void DeleteFileEvent(FileEvent f);
    }
}
