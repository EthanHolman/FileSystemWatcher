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
        private int spamClickCounter = 0;


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

        private void Start() {
            this.app.Start();
            toolstripStartBtn.Enabled = false;
            startToolStripMenuItem.Enabled = false;
            toolstripStopBtn.Enabled = true;
            stopToolStripMenuItem.Enabled = true;
        }

        private void Stop() {
            this.app.Stop();
            toolstripStartBtn.Enabled = true;
            startToolStripMenuItem.Enabled = true;
            toolstripStopBtn.Enabled = false;
            stopToolStripMenuItem.Enabled = false;
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
            if(!app.LogAllEventsToBackend()) {
                MessageBox.Show("An error occurred when saving the current data to SQLite", "Error");
            }
        }

        private void toolstripStartBtn_Click(object sender, EventArgs e) {
            this.Start();
        }

        private void toolstripStopBtn_Click(object sender, EventArgs e) {
            this.Stop();
        }

        private void toolstripPrefBtn_Click(object sender, EventArgs e) {
            new SettingsModal(app).ShowDialog();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Stop();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Start();
        }

        private void label1_Click(object sender, EventArgs e) {
            spamClickCounter++;
            if(spamClickCounter == 4) MessageBox.Show("Could you please stop spam clicking the text?");

            if(spamClickCounter == 7) {
                label1.Visible = false;
                MessageBox.Show("There! Now you can't click on it anymore!");
            }
        }

        private void MainAppWindow_Click(object sender, EventArgs e) {
            if(!label1.Visible) {
                spamClickCounter++;
                if(spamClickCounter == 10) MessageBox.Show("Really? Stop spam clicking!!!! Don't make me disable the entire window.");
                if(spamClickCounter == 12) MessageBox.Show("Seriously, you need to stop. Or else something bad will happen. You have been warned.");
                if(spamClickCounter == 17) Application.Exit();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void viewEditLogsToolStripMenuItem_Click(object sender, EventArgs e) {
            new DatabaseQuery(this.app).Show();
        }
    }
}
