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
        public DatabaseQuery(WatcherService a) {
            this.app = a;
            InitializeComponent();
        }

        private void btnRunQuery_Click(object sender, EventArgs e) {
            List<string> data = new List<string>();
            data.Add("txt");

            List<FileEvent> returnedData = app.GetLoggerService().GetFileEvents(DateTime.Now, DateTime.Now, data);
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
            filterExtensions.Items.RemoveAt(filterExtensions.SelectedIndex);
        }
    }
}
