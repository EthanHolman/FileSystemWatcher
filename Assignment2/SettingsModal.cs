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
    public partial class SettingsModal : Form {

        private WatcherService app;

        public SettingsModal(WatcherService appSvc) {
            this.app = appSvc;
            InitializeComponent();

            // Poplate fields with default values
            monitoringDir.Text = this.app.MonitorPath;
            logPath.Text = this.app.LogPath;
            logFileName.Text = this.app.LogFileName;
            includeSubdirs.Checked = this.app.MonitorSubDirectories;
        }

        private void btnChooseMonitorDir_Click(object sender, EventArgs e) {
            DialogResult result = chooseMonDirDialog.ShowDialog();
            if(result == DialogResult.OK) {
                monitoringDir.Text = chooseMonDirDialog.SelectedPath;
                this.app.MonitorPath = chooseMonDirDialog.SelectedPath;
                this.app.InitCompleted = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void logFileName_TextChanged(object sender, EventArgs e) {
            this.app.LogFileName = logFileName.Text;
        }

        private void includeSubdirs_CheckedChanged(object sender, EventArgs e) {
            this.app.MonitorSubDirectories = includeSubdirs.Checked;
        }

        private void btnChooseLogPath_Click(object sender, EventArgs e) {
            DialogResult result = chooseLogDirDialog.ShowDialog();
            if(result == DialogResult.OK) {
                logPath.Text = chooseLogDirDialog.SelectedPath;
                this.app.LogPath = chooseLogDirDialog.SelectedPath;
                this.app.InitCompleted = false;
            }
        }
    }
}
