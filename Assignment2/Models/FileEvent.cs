using System;

namespace Assignment2.Models {
    public class FileEvent {
        public FileEvent(string fileName, string filePath, FileEvent eventType, DateTime timestamp, ObjectType objType) {
            this.FileName = fileName;
            this.FilePath = filePath;
            this.EventType = eventType;
            this.Timestamp = timestamp;
            this.ObjType = objType;
        }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public FileEvent EventType { get; set; }
        public DateTime Timestamp { get; set; }
        public ObjectType ObjType { get; set; }
    }
}
