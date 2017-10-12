﻿using Assignment2.Models;
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

        private void startWatcher_Click(object sender, EventArgs e) {
            app.Start();
            startWatcher.Enabled = false;
            stopWatcher.Enabled = true;
        }

        private void stopWatcher_Click(object sender, EventArgs e) {
            app.Stop();
            startWatcher.Enabled = true;
            stopWatcher.Enabled = false;
        }

        private void btnOpenSettings_Click(object sender, EventArgs e) {
            new SettingsModal(app).ShowDialog();
        }

        private void btnShowAbout_Click(object sender, EventArgs e) {
            new AboutModal().ShowDialog();
        }

        private void MainAppWindow_Load(object sender, EventArgs e) {
            // Show the settings modal on launch so the user can pick their options
            new SettingsModal(app).ShowDialog();
        }
    }
}
