namespace Assignment2 {
    partial class MainAppWindow {
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
            this.btnOpenSettings = new System.Windows.Forms.Button();
            this.btnShowAbout = new System.Windows.Forms.Button();
            this.FileEventsListView = new System.Windows.Forms.ListView();
            this.Timestamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EventType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ObjectType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // startWatcher
            // 
            this.startWatcher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.stopWatcher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stopWatcher.Enabled = false;
            this.stopWatcher.Location = new System.Drawing.Point(93, 322);
            this.stopWatcher.Name = "stopWatcher";
            this.stopWatcher.Size = new System.Drawing.Size(75, 23);
            this.stopWatcher.TabIndex = 2;
            this.stopWatcher.Text = "Stop";
            this.stopWatcher.UseVisualStyleBackColor = true;
            this.stopWatcher.Click += new System.EventHandler(this.stopWatcher_Click);
            // 
            // btnOpenSettings
            // 
            this.btnOpenSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenSettings.Location = new System.Drawing.Point(501, 322);
            this.btnOpenSettings.Name = "btnOpenSettings";
            this.btnOpenSettings.Size = new System.Drawing.Size(75, 23);
            this.btnOpenSettings.TabIndex = 6;
            this.btnOpenSettings.Text = "Settings";
            this.btnOpenSettings.UseVisualStyleBackColor = true;
            this.btnOpenSettings.Click += new System.EventHandler(this.btnOpenSettings_Click);
            // 
            // btnShowAbout
            // 
            this.btnShowAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowAbout.Location = new System.Drawing.Point(582, 322);
            this.btnShowAbout.Name = "btnShowAbout";
            this.btnShowAbout.Size = new System.Drawing.Size(75, 23);
            this.btnShowAbout.TabIndex = 7;
            this.btnShowAbout.Text = "About";
            this.btnShowAbout.UseVisualStyleBackColor = true;
            this.btnShowAbout.Click += new System.EventHandler(this.btnShowAbout_Click);
            // 
            // FileEventsListView
            // 
            this.FileEventsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileEventsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Timestamp,
            this.ItemName,
            this.EventType,
            this.ObjectType,
            this.Path});
            this.FileEventsListView.Location = new System.Drawing.Point(12, 12);
            this.FileEventsListView.Name = "FileEventsListView";
            this.FileEventsListView.Size = new System.Drawing.Size(645, 304);
            this.FileEventsListView.TabIndex = 8;
            this.FileEventsListView.UseCompatibleStateImageBehavior = false;
            this.FileEventsListView.View = System.Windows.Forms.View.Details;
            // 
            // Timestamp
            // 
            this.Timestamp.Text = "Timestamp";
            this.Timestamp.Width = 71;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Item Name";
            this.ItemName.Width = 69;
            // 
            // EventType
            // 
            this.EventType.Text = "Event Type";
            this.EventType.Width = 70;
            // 
            // ObjectType
            // 
            this.ObjectType.Text = "Object Type";
            this.ObjectType.Width = 73;
            // 
            // Path
            // 
            this.Path.Text = "Path";
            this.Path.Width = 358;
            // 
            // MainAppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 357);
            this.Controls.Add(this.FileEventsListView);
            this.Controls.Add(this.btnShowAbout);
            this.Controls.Add(this.btnOpenSettings);
            this.Controls.Add(this.stopWatcher);
            this.Controls.Add(this.startWatcher);
            this.Name = "MainAppWindow";
            this.Text = "File System Watcher";
            this.Load += new System.EventHandler(this.MainAppWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button startWatcher;
        private System.Windows.Forms.Button stopWatcher;
        private System.Windows.Forms.Button btnOpenSettings;
        private System.Windows.Forms.Button btnShowAbout;
        private System.Windows.Forms.ListView FileEventsListView;
        private System.Windows.Forms.ColumnHeader Timestamp;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader EventType;
        private System.Windows.Forms.ColumnHeader ObjectType;
        private System.Windows.Forms.ColumnHeader Path;
    }
}

