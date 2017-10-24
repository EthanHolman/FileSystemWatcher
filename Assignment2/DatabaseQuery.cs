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
    public partial class DatabaseQuery : Form {
        private WatcherService app;
        private ILoggerService loggerService;
        public DatabaseQuery(WatcherService a) {
            this.app = a;
            this.loggerService = a.GetLoggerService();
            InitializeComponent();
        }

        private void btnRunQuery_Click(object sender, EventArgs e) {
            FileEventsListView.Items.Clear();
            List<FileEvent> returnedData = this.loggerService.GetFileEvents(filterExtensions.Items.Cast<string>().ToList());
            foreach(FileEvent f in returnedData) {
                ListViewItem temp = new ListViewItem(f.Timestamp.ToString());
                temp.SubItems.Add(f.FileName);
                temp.SubItems.Add(f.EventType.ToString());
                temp.SubItems.Add(f.ObjType.ToString());
                temp.SubItems.Add(f.FilePath);
                FileEventsListView.Items.Add(temp);
            }
        }

        private void btnAddExtension_Click(object sender, EventArgs e) {
            if(extensionInput.Text.Length > 0) {
                filterExtensions.Items.Add(extensionInput.Text);
                extensionInput.Clear();
            }
        }

        private void btnRemoveSelectedExtension_Click(object sender, EventArgs e) {
            int selected = filterExtensions.SelectedIndex;
            filterExtensions.Items.RemoveAt(selected);
            if(selected > 0) filterExtensions.SetSelected(selected - 1, true);
            else btnRemoveSelectedExtension.Visible = false;
        }

        private void filterExtensions_SelectedIndexChanged(object sender, EventArgs e) {
            btnRemoveSelectedExtension.Visible = true;
        }

        private void btnClearTable_Click(object sender, EventArgs e) {
            var confirm = MessageBox.Show("Are you sure? This operation will irreversibly clear all contents of logs", "Erase Entire Database?", MessageBoxButtons.YesNo);
            if(confirm.Equals(DialogResult.Yes)) {
                if(this.loggerService.EraseData()) {
                    MessageBox.Show("Database cleared successfully!", "File System Watcher");
                    FileEventsListView.Items.Clear();
                } else MessageBox.Show("An error was encountered when attempting to clear the database", "Bad things happen...");
            }
        }
    }
}
