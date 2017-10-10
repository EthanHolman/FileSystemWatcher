using Assignment2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2 {
    public partial class Form1 : Form {
        private WatcherService w;
        public Form1() {
            InitializeComponent();
            this.w = new WatcherService(@"C:\Temp\", new FileLoggerService(@"C:\appLog.log"));

            //this.w.OnFilesystemChange += WatcherService_OnFilesystemChange;
            this.w.AddChangedEventHandler(WatcherService_OnFilesystemChange);
        }

        delegate void fschange(FileEvent f);
        private void WatcherService_OnFilesystemChange(FileEvent f) {
            if(listView1.InvokeRequired) { // Cross-thread safety
                fschange fs = new fschange(WatcherService_OnFilesystemChange);
                this.Invoke(fs, new object[] { f });
            } else {
                ListViewItem temp = new ListViewItem(f.Timestamp.ToString());
                temp.SubItems.Add(f.FileName);
                temp.SubItems.Add(f.FilePath);
                temp.SubItems.Add(f.EventType.ToString());
                listView1.Items.Add(temp);
            }
        }

        private void startWatcher_Click(object sender, EventArgs e) {
            this.w.Start();
            startWatcher.Enabled = false;
            logFilePath.Enabled = false;
            stopWatcher.Enabled = true;
        }

        private void stopWatcher_Click(object sender, EventArgs e) {
            this.w.Stop();
        }
    }
}
