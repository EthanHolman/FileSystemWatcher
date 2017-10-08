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
            this.w = new WatcherService(@"C:\Users\Ethan Holman\Temp\", new FileLoggerService(@"C:\Users\Ethan Holman\appLog.log"));
            listBox1.DataSource = w.Events;
        }

        private void dataView_SelectedIndexChanged(object sender, EventArgs e) {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void startWatcher_Click(object sender, EventArgs e) {
            this.w.Start();
        }

        private void stopWatcher_Click(object sender, EventArgs e) {
            //this.w.Stop();
            listBox1.DataSource = null;
            listBox1.DataSource = w.Events;
        }
    }
}
