namespace Assignment2 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.startWatcher = new System.Windows.Forms.Button();
            this.stopWatcher = new System.Windows.Forms.Button();
            this.logFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EventType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // startWatcher
            // 
            this.startWatcher.Location = new System.Drawing.Point(12, 322);
            this.startWatcher.Name = "startWatcher";
            this.startWatcher.Size = new System.Drawing.Size(75, 23);
            this.startWatcher.TabIndex = 1;
            this.startWatcher.Text = "Start";
            this.startWatcher.UseVisualStyleBackColor = true;
            this.startWatcher.Click += new System.EventHandler(this.startWatcher_Click);
            // 
            // stopWatcher
            // 
            this.stopWatcher.Enabled = false;
            this.stopWatcher.Location = new System.Drawing.Point(93, 322);
            this.stopWatcher.Name = "stopWatcher";
            this.stopWatcher.Size = new System.Drawing.Size(75, 23);
            this.stopWatcher.TabIndex = 2;
            this.stopWatcher.Text = "Stop";
            this.stopWatcher.UseVisualStyleBackColor = true;
            this.stopWatcher.Click += new System.EventHandler(this.stopWatcher_Click);
            // 
            // logFilePath
            // 
            this.logFilePath.Location = new System.Drawing.Point(263, 325);
            this.logFilePath.Name = "logFilePath";
            this.logFilePath.Size = new System.Drawing.Size(256, 20);
            this.logFilePath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Log File Path";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Time,
            this.Filename,
            this.Path,
            this.EventType});
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(507, 304);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 71;
            // 
            // Filename
            // 
            this.Filename.Text = "Filename";
            this.Filename.Width = 120;
            // 
            // Path
            // 
            this.Path.Text = "Path";
            this.Path.Width = 92;
            // 
            // EventType
            // 
            this.EventType.Text = "Event Type";
            this.EventType.Width = 103;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 357);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logFilePath);
            this.Controls.Add(this.stopWatcher);
            this.Controls.Add(this.startWatcher);
            this.Name = "Form1";
            this.Text = "File System Watcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startWatcher;
        private System.Windows.Forms.Button stopWatcher;
        private System.Windows.Forms.TextBox logFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Filename;
        private System.Windows.Forms.ColumnHeader Path;
        private System.Windows.Forms.ColumnHeader EventType;
    }
}

