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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAppWindow));
            this.FileEventsListView = new System.Windows.Forms.ListView();
            this.Timestamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EventType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ObjectType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileSystemWatcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEditLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCurrentDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolstripStartBtn = new System.Windows.Forms.ToolStripButton();
            this.toolstripStopBtn = new System.Windows.Forms.ToolStripButton();
            this.toolstripPrefBtn = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.FileEventsListView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileEventsListView.Location = new System.Drawing.Point(12, 117);
            this.FileEventsListView.Name = "FileEventsListView";
            this.FileEventsListView.Size = new System.Drawing.Size(686, 303);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileSystemWatcherToolStripMenuItem,
            this.loggingToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(710, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileSystemWatcherToolStripMenuItem
            // 
            this.fileSystemWatcherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileSystemWatcherToolStripMenuItem.Name = "fileSystemWatcherToolStripMenuItem";
            this.fileSystemWatcherToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.fileSystemWatcherToolStripMenuItem.Text = "&File System Watcher";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem.Text = "&Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // loggingToolStripMenuItem
            // 
            this.loggingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.viewEditLogsToolStripMenuItem,
            this.saveCurrentDataToolStripMenuItem});
            this.loggingToolStripMenuItem.Name = "loggingToolStripMenuItem";
            this.loggingToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.loggingToolStripMenuItem.Text = "&Logging";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Enabled = false;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // viewEditLogsToolStripMenuItem
            // 
            this.viewEditLogsToolStripMenuItem.Name = "viewEditLogsToolStripMenuItem";
            this.viewEditLogsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.viewEditLogsToolStripMenuItem.Text = "View/Edit Logs";
            this.viewEditLogsToolStripMenuItem.Click += new System.EventHandler(this.viewEditLogsToolStripMenuItem_Click);
            // 
            // saveCurrentDataToolStripMenuItem
            // 
            this.saveCurrentDataToolStripMenuItem.Name = "saveCurrentDataToolStripMenuItem";
            this.saveCurrentDataToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.saveCurrentDataToolStripMenuItem.Text = "Save Current Data";
            this.saveCurrentDataToolStripMenuItem.Click += new System.EventHandler(this.saveCurrentDataToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "File System Events";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripStartBtn,
            this.toolstripStopBtn,
            this.toolstripPrefBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.toolStrip1.Size = new System.Drawing.Size(710, 34);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "mainToolStrip";
            // 
            // toolstripStartBtn
            // 
            this.toolstripStartBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolstripStartBtn.Image = ((System.Drawing.Image)(resources.GetObject("toolstripStartBtn.Image")));
            this.toolstripStartBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripStartBtn.Name = "toolstripStartBtn";
            this.toolstripStartBtn.Size = new System.Drawing.Size(55, 21);
            this.toolstripStartBtn.Text = "Start";
            this.toolstripStartBtn.Click += new System.EventHandler(this.toolstripStartBtn_Click);
            // 
            // toolstripStopBtn
            // 
            this.toolstripStopBtn.Enabled = false;
            this.toolstripStopBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolstripStopBtn.Image = ((System.Drawing.Image)(resources.GetObject("toolstripStopBtn.Image")));
            this.toolstripStopBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripStopBtn.Name = "toolstripStopBtn";
            this.toolstripStopBtn.Size = new System.Drawing.Size(55, 21);
            this.toolstripStopBtn.Text = "Stop";
            this.toolstripStopBtn.Click += new System.EventHandler(this.toolstripStopBtn_Click);
            // 
            // toolstripPrefBtn
            // 
            this.toolstripPrefBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolstripPrefBtn.Image = ((System.Drawing.Image)(resources.GetObject("toolstripPrefBtn.Image")));
            this.toolstripPrefBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripPrefBtn.Name = "toolstripPrefBtn";
            this.toolstripPrefBtn.Size = new System.Drawing.Size(96, 21);
            this.toolstripPrefBtn.Text = "Preferences";
            this.toolstripPrefBtn.Click += new System.EventHandler(this.toolstripPrefBtn_Click);
            // 
            // MainAppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 432);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FileEventsListView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainAppWindow";
            this.Text = "File System Watcher";
            this.Load += new System.EventHandler(this.MainAppWindow_Load);
            this.Click += new System.EventHandler(this.MainAppWindow_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView FileEventsListView;
        private System.Windows.Forms.ColumnHeader Timestamp;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader EventType;
        private System.Windows.Forms.ColumnHeader ObjectType;
        private System.Windows.Forms.ColumnHeader Path;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileSystemWatcherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loggingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEditLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCurrentDataToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolstripStartBtn;
        private System.Windows.Forms.ToolStripButton toolstripStopBtn;
        private System.Windows.Forms.ToolStripButton toolstripPrefBtn;
    }
}

