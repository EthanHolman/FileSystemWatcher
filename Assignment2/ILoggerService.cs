using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2.Models;

namespace Assignment2 {
    public interface ILoggerService {
        void LogFileEvent(FileEvent f);
    }
}
