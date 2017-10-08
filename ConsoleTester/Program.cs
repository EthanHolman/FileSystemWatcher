using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2;

namespace ConsoleTester {
    class Program {
        static void Main(string[] args) {

            String path = @"C:\Users\Ethan Holman\Temp\";

            WatcherService w = new WatcherService(path, new FileLoggerService(@"C:\Users\Ethan Holman\appLog.log"));
            w.Start();
            
            while(true);
        }
    }
}
