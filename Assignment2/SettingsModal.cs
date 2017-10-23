using Assignment2.Services;
using System;
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
            this.app.InitCompleted = false;
        }

        private void includeSubdirs_CheckedChanged(object sender, EventArgs e) {
            this.app.MonitorSubDirectories = includeSubdirs.Checked;
            this.app.InitCompleted = false;
        }

        private void btnChooseLogPath_Click(object sender, EventArgs e) {
            DialogResult result = chooseLogDirDialog.ShowDialog();
            if(result == DialogResult.OK) {
                logPath.Text = chooseLogDirDialog.SelectedPath;
                this.app.LogPath = chooseLogDirDialog.SelectedPath;
                this.app.InitCompleted = false;
            }
        }

        private void enableSQLite_CheckedChanged(object sender, EventArgs e) {
            app.LogToSqlite = enableSQLite.Checked;
            
            // Enable or disable input fields based on whether or not checkbox is enabled
            DBPath.Enabled = enableSQLite.Checked;
            DBTableName.Enabled = enableSQLite.Checked;
            btnChooseSqlitePath.Enabled = enableSQLite.Checked;
        }

        private void enableFileLog_CheckedChanged(object sender, EventArgs e) {
            app.LogToFile = enableFileLog.Checked;

            // Enable or disable input fields based on whether or not checkbox is enabled
            logPath.Enabled = enableFileLog.Checked;
            logFileName.Enabled = enableFileLog.Checked;
            btnChooseLogPath.Enabled = enableFileLog.Checked;
        }
    }
}
