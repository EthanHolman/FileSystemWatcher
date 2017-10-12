using System;

namespace Assignment2.Models {
    public class FileEvent {
        public FileEvent(string fileName, string filePath, FileEventTypes eventType, DateTime timestamp, ObjectTypes objType) {
            this.FileName = fileName;
            this.FilePath = filePath;
            this.EventType = eventType;
            this.Timestamp = timestamp;
            this.ObjType = objType;
        }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public FileEventTypes EventType { get; set; }
        public DateTime Timestamp { get; set; }
        public ObjectTypes ObjType { get; set; }
        public override string ToString() {
            return FileName + ", " + FilePath + ", " + EventType + ", " + Timestamp;
        }
    }
}
