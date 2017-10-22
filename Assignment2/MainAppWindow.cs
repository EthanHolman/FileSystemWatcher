using Assignment2.Models;
using Assignment2.Services;
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
    public partial class MainAppWindow : Form {

        private WatcherService app;
        public delegate void FSChange(FileEvent f);

        public MainAppWindow() {
            InitializeComponent();
            app = new WatcherService();
            app.AddChangedEventHandler(WatcherService_OnFilesystemChange);
        }
        
        private void WatcherService_OnFilesystemChange(FileEvent f) {
            // Cross-thread safety
            if(FileEventsListView.InvokeRequired) {
                FSChange fs = new FSChange(WatcherService_OnFilesystemChange);
                this.Invoke(fs, new object[] { f });
            } else {
                ListViewItem temp = new ListViewItem(f.Timestamp.ToString());
                temp.SubItems.Add(f.FileName);
                temp.SubItems.Add(f.EventType.ToString());
                temp.SubItems.Add(f.ObjType.ToString());
                temp.SubItems.Add(f.FilePath);
                FileEventsListView.Items.Add(temp);
            }
        }

        private void MainAppWindow_Load(object sender, EventArgs e) {
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            new AboutModal().ShowDialog();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e) {
            new SettingsModal(app).ShowDialog();
        }

        private void saveCurrentDataToolStripMenuItem_Click(object sender, EventArgs e) {
            app.LogAllEventsToBackend();
        }

        private void toolstripStartBtn_Click(object sender, EventArgs e) {
            this.app.Start();
        }

        private void toolstripStopBtn_Click(object sender, EventArgs e) {
            this.app.Stop();
        }

        private void toolstripPrefBtn_Click(object sender, EventArgs e) {
            new SettingsModal(app).ShowDialog();
        }
    }
}
