using FSWatcher.Services;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSWatcher {
    public partial class SettingsModal : Form {

        private WatcherService app;

        public SettingsModal(WatcherService appSvc) {
            this.app = appSvc;
            InitializeComponent();

            // Poplate fields with values set in app
            enableLiveLogging.Checked = app.LiveLogging;
            monitoringDir.Text = this.app.MonitorPath;
            logPath.Text = this.app.LogPath;
            logFileName.Text = this.app.LogFileName;
            includeSubdirs.Checked = this.app.MonitorSubDirectories;
            enableSQLite.Checked = this.app.LogToSqlite;
            enableFileLog.Checked = this.app.LogToFile;
            DBPath.Text = this.app.SqliteFileName;
            DBTableName.Text = this.app.SqliteTableName;
            foreach(string item in this.app.ExtensionsToWatch) { filterExtensions.Items.Add(item); }

            updateEnabledFields();
        }

        private void updateEnabledFields() {
            DBTableName.Enabled = btnChooseSqlitePath.Enabled = lblSqlitePath.Enabled = lblSqliteTableName.Enabled = enableSQLite.Checked;
            lblLogFileLoc.Enabled = lblLogFileName.Enabled = logFileName.Enabled = btnChooseLogPath.Enabled = enableFileLog.Checked;
        }

        private void saveExtensionFilter() {
            this.app.ExtensionsToWatch = filterExtensions.Items.Cast<string>().ToList();
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
            updateEnabledFields();
        }

        private void enableFileLog_CheckedChanged(object sender, EventArgs e) {
            app.LogToFile = enableFileLog.Checked;
            updateEnabledFields();
        }

        private void DBTableName_TextChanged(object sender, EventArgs e) {
            this.app.SqliteTableName = DBTableName.Text;
        }

        private void enableLiveLogging_CheckedChanged(object sender, EventArgs e) {
            this.app.LiveLogging = enableLiveLogging.Checked;
        }

        private void btnAddExtension_Click(object sender, EventArgs e) {
            if(extensionInput.Text.Length > 0) {
                filterExtensions.Items.Add(extensionInput.Text);
                extensionInput.Clear();
                saveExtensionFilter();
            }
        }

        private void btnRemoveSelectedExtension_Click(object sender, EventArgs e) {
            int selected = filterExtensions.SelectedIndex;
            filterExtensions.Items.RemoveAt(selected);
            saveExtensionFilter();
            if(selected > 0) filterExtensions.SetSelected(selected - 1, true);
            else btnRemoveSelectedExtension.Enabled = false;
        }

        private void filterExtensions_SelectedIndexChanged(object sender, EventArgs e) {
            btnRemoveSelectedExtension.Enabled = true;
        }
    }
}
