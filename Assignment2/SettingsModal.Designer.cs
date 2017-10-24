namespace Assignment2 {
    partial class SettingsModal {
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
            this.monitoringDir = new System.Windows.Forms.TextBox();
            this.btnChooseMonitorDir = new System.Windows.Forms.Button();
            this.includeSubdirs = new System.Windows.Forms.CheckBox();
            this.lblLogFileLoc = new System.Windows.Forms.Label();
            this.logPath = new System.Windows.Forms.TextBox();
            this.btnChooseLogPath = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.chooseMonDirDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.logFileName = new System.Windows.Forms.TextBox();
            this.lblLogFileName = new System.Windows.Forms.Label();
            this.chooseLogDirDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.enableLiveLogging = new System.Windows.Forms.CheckBox();
            this.btnChooseSqlitePath = new System.Windows.Forms.Button();
            this.lblSqliteTableName = new System.Windows.Forms.Label();
            this.DBTableName = new System.Windows.Forms.TextBox();
            this.enableSQLite = new System.Windows.Forms.CheckBox();
            this.DBPath = new System.Windows.Forms.TextBox();
            this.lblSqlitePath = new System.Windows.Forms.Label();
            this.enableFileLog = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.filterExtensions = new System.Windows.Forms.ListBox();
            this.btnRemoveSelectedExtension = new System.Windows.Forms.Button();
            this.extensionInput = new System.Windows.Forms.TextBox();
            this.btnAddExtension = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monitoringDir
            // 
            this.monitoringDir.Enabled = false;
            this.monitoringDir.Location = new System.Drawing.Point(18, 128);
            this.monitoringDir.Name = "monitoringDir";
            this.monitoringDir.Size = new System.Drawing.Size(216, 20);
            this.monitoringDir.TabIndex = 1;
            // 
            // btnChooseMonitorDir
            // 
            this.btnChooseMonitorDir.Location = new System.Drawing.Point(245, 126);
            this.btnChooseMonitorDir.Name = "btnChooseMonitorDir";
            this.btnChooseMonitorDir.Size = new System.Drawing.Size(75, 23);
            this.btnChooseMonitorDir.TabIndex = 2;
            this.btnChooseMonitorDir.Text = "Change";
            this.btnChooseMonitorDir.UseVisualStyleBackColor = true;
            this.btnChooseMonitorDir.Click += new System.EventHandler(this.btnChooseMonitorDir_Click);
            // 
            // includeSubdirs
            // 
            this.includeSubdirs.AutoSize = true;
            this.includeSubdirs.Location = new System.Drawing.Point(18, 157);
            this.includeSubdirs.Name = "includeSubdirs";
            this.includeSubdirs.Size = new System.Drawing.Size(137, 17);
            this.includeSubdirs.TabIndex = 3;
            this.includeSubdirs.Text = "Include Subdirectories?";
            this.includeSubdirs.UseVisualStyleBackColor = true;
            this.includeSubdirs.CheckedChanged += new System.EventHandler(this.includeSubdirs_CheckedChanged);
            // 
            // lblLogFileLoc
            // 
            this.lblLogFileLoc.AutoSize = true;
            this.lblLogFileLoc.Enabled = false;
            this.lblLogFileLoc.Location = new System.Drawing.Point(35, 538);
            this.lblLogFileLoc.Name = "lblLogFileLoc";
            this.lblLogFileLoc.Size = new System.Drawing.Size(91, 13);
            this.lblLogFileLoc.TabIndex = 4;
            this.lblLogFileLoc.Text = "Log File Location:";
            // 
            // logPath
            // 
            this.logPath.Enabled = false;
            this.logPath.Location = new System.Drawing.Point(132, 535);
            this.logPath.Name = "logPath";
            this.logPath.Size = new System.Drawing.Size(219, 20);
            this.logPath.TabIndex = 5;
            // 
            // btnChooseLogPath
            // 
            this.btnChooseLogPath.Enabled = false;
            this.btnChooseLogPath.Location = new System.Drawing.Point(357, 535);
            this.btnChooseLogPath.Name = "btnChooseLogPath";
            this.btnChooseLogPath.Size = new System.Drawing.Size(75, 23);
            this.btnChooseLogPath.TabIndex = 6;
            this.btnChooseLogPath.Text = "Change";
            this.btnChooseLogPath.UseVisualStyleBackColor = true;
            this.btnChooseLogPath.Click += new System.EventHandler(this.btnChooseLogPath_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(457, 340);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 35);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Done";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // logFileName
            // 
            this.logFileName.Enabled = false;
            this.logFileName.Location = new System.Drawing.Point(132, 558);
            this.logFileName.Name = "logFileName";
            this.logFileName.Size = new System.Drawing.Size(219, 20);
            this.logFileName.TabIndex = 9;
            this.logFileName.TextChanged += new System.EventHandler(this.logFileName_TextChanged);
            // 
            // lblLogFileName
            // 
            this.lblLogFileName.AutoSize = true;
            this.lblLogFileName.Enabled = false;
            this.lblLogFileName.Location = new System.Drawing.Point(48, 561);
            this.lblLogFileName.Name = "lblLogFileName";
            this.lblLogFileName.Size = new System.Drawing.Size(78, 13);
            this.lblLogFileName.TabIndex = 10;
            this.lblLogFileName.Text = "Log File Name:";
            // 
            // enableLiveLogging
            // 
            this.enableLiveLogging.AutoSize = true;
            this.enableLiveLogging.Location = new System.Drawing.Point(18, 56);
            this.enableLiveLogging.Name = "enableLiveLogging";
            this.enableLiveLogging.Size = new System.Drawing.Size(198, 17);
            this.enableLiveLogging.TabIndex = 0;
            this.enableLiveLogging.Text = "Log Filesystem Events as they occur";
            this.enableLiveLogging.UseVisualStyleBackColor = true;
            this.enableLiveLogging.CheckedChanged += new System.EventHandler(this.enableLiveLogging_CheckedChanged);
            // 
            // btnChooseSqlitePath
            // 
            this.btnChooseSqlitePath.Enabled = false;
            this.btnChooseSqlitePath.Location = new System.Drawing.Point(413, 444);
            this.btnChooseSqlitePath.Name = "btnChooseSqlitePath";
            this.btnChooseSqlitePath.Size = new System.Drawing.Size(75, 23);
            this.btnChooseSqlitePath.TabIndex = 5;
            this.btnChooseSqlitePath.Text = "Change";
            this.btnChooseSqlitePath.UseVisualStyleBackColor = true;
            // 
            // lblSqliteTableName
            // 
            this.lblSqliteTableName.AutoSize = true;
            this.lblSqliteTableName.Enabled = false;
            this.lblSqliteTableName.Location = new System.Drawing.Point(65, 472);
            this.lblSqliteTableName.Name = "lblSqliteTableName";
            this.lblSqliteTableName.Size = new System.Drawing.Size(117, 13);
            this.lblSqliteTableName.TabIndex = 4;
            this.lblSqliteTableName.Text = "Database Table Name:";
            // 
            // DBTableName
            // 
            this.DBTableName.Enabled = false;
            this.DBTableName.Location = new System.Drawing.Point(188, 469);
            this.DBTableName.Name = "DBTableName";
            this.DBTableName.Size = new System.Drawing.Size(219, 20);
            this.DBTableName.TabIndex = 3;
            this.DBTableName.TextChanged += new System.EventHandler(this.DBTableName_TextChanged);
            // 
            // enableSQLite
            // 
            this.enableSQLite.AutoSize = true;
            this.enableSQLite.Location = new System.Drawing.Point(18, 423);
            this.enableSQLite.Name = "enableSQLite";
            this.enableSQLite.Size = new System.Drawing.Size(135, 17);
            this.enableSQLite.TabIndex = 2;
            this.enableSQLite.Text = "Enable SQLite Logging";
            this.enableSQLite.UseVisualStyleBackColor = true;
            this.enableSQLite.CheckedChanged += new System.EventHandler(this.enableSQLite_CheckedChanged);
            // 
            // DBPath
            // 
            this.DBPath.Enabled = false;
            this.DBPath.Location = new System.Drawing.Point(188, 446);
            this.DBPath.Name = "DBPath";
            this.DBPath.Size = new System.Drawing.Size(219, 20);
            this.DBPath.TabIndex = 1;
            // 
            // lblSqlitePath
            // 
            this.lblSqlitePath.AutoSize = true;
            this.lblSqlitePath.Enabled = false;
            this.lblSqlitePath.Location = new System.Drawing.Point(35, 449);
            this.lblSqlitePath.Name = "lblSqlitePath";
            this.lblSqlitePath.Size = new System.Drawing.Size(147, 13);
            this.lblSqlitePath.TabIndex = 0;
            this.lblSqlitePath.Text = "Path to SQLite Database File:";
            // 
            // enableFileLog
            // 
            this.enableFileLog.AutoSize = true;
            this.enableFileLog.Enabled = false;
            this.enableFileLog.Location = new System.Drawing.Point(18, 512);
            this.enableFileLog.Name = "enableFileLog";
            this.enableFileLog.Size = new System.Drawing.Size(119, 17);
            this.enableFileLog.TabIndex = 11;
            this.enableFileLog.Text = "Enable File Logging";
            this.enableFileLog.UseVisualStyleBackColor = true;
            this.enableFileLog.CheckedChanged += new System.EventHandler(this.enableFileLog_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 37);
            this.label3.TabIndex = 12;
            this.label3.Text = "Preferences";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(0, 15);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.filterExtensions);
            this.panel1.Controls.Add(this.btnRemoveSelectedExtension);
            this.panel1.Controls.Add(this.extensionInput);
            this.panel1.Controls.Add(this.btnAddExtension);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.enableFileLog);
            this.panel1.Controls.Add(this.logPath);
            this.panel1.Controls.Add(this.btnChooseSqlitePath);
            this.panel1.Controls.Add(this.lblLogFileName);
            this.panel1.Controls.Add(this.enableLiveLogging);
            this.panel1.Controls.Add(this.lblLogFileLoc);
            this.panel1.Controls.Add(this.lblSqliteTableName);
            this.panel1.Controls.Add(this.logFileName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnChooseLogPath);
            this.panel1.Controls.Add(this.DBTableName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.enableSQLite);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.DBPath);
            this.panel1.Controls.Add(this.lblSqlitePath);
            this.panel1.Controls.Add(this.monitoringDir);
            this.panel1.Controls.Add(this.btnChooseMonitorDir);
            this.panel1.Controls.Add(this.includeSubdirs);
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15);
            this.panel1.Size = new System.Drawing.Size(542, 285);
            this.panel1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Leave blank for all";
            // 
            // filterExtensions
            // 
            this.filterExtensions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterExtensions.FormattingEnabled = true;
            this.filterExtensions.ItemHeight = 15;
            this.filterExtensions.Location = new System.Drawing.Point(19, 255);
            this.filterExtensions.Name = "filterExtensions";
            this.filterExtensions.Size = new System.Drawing.Size(170, 109);
            this.filterExtensions.TabIndex = 17;
            this.filterExtensions.SelectedIndexChanged += new System.EventHandler(this.filterExtensions_SelectedIndexChanged);
            // 
            // btnRemoveSelectedExtension
            // 
            this.btnRemoveSelectedExtension.Enabled = false;
            this.btnRemoveSelectedExtension.Location = new System.Drawing.Point(195, 340);
            this.btnRemoveSelectedExtension.Name = "btnRemoveSelectedExtension";
            this.btnRemoveSelectedExtension.Size = new System.Drawing.Size(170, 25);
            this.btnRemoveSelectedExtension.TabIndex = 20;
            this.btnRemoveSelectedExtension.Text = "Remove Selected";
            this.btnRemoveSelectedExtension.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedExtension.Click += new System.EventHandler(this.btnRemoveSelectedExtension_Click);
            // 
            // extensionInput
            // 
            this.extensionInput.Location = new System.Drawing.Point(195, 314);
            this.extensionInput.Name = "extensionInput";
            this.extensionInput.Size = new System.Drawing.Size(81, 20);
            this.extensionInput.TabIndex = 18;
            // 
            // btnAddExtension
            // 
            this.btnAddExtension.Location = new System.Drawing.Point(284, 312);
            this.btnAddExtension.Name = "btnAddExtension";
            this.btnAddExtension.Size = new System.Drawing.Size(81, 23);
            this.btnAddExtension.TabIndex = 19;
            this.btnAddExtension.Text = "Add";
            this.btnAddExtension.UseVisualStyleBackColor = true;
            this.btnAddExtension.Click += new System.EventHandler(this.btnAddExtension_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "Filter by Extension";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "General Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Logging Options";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "Where To Monitor";
            // 
            // SettingsModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(565, 381);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsModal";
            this.Text = "Preferences";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox monitoringDir;
        private System.Windows.Forms.Button btnChooseMonitorDir;
        private System.Windows.Forms.CheckBox includeSubdirs;
        private System.Windows.Forms.Label lblLogFileLoc;
        private System.Windows.Forms.TextBox logPath;
        private System.Windows.Forms.Button btnChooseLogPath;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FolderBrowserDialog chooseMonDirDialog;
        private System.Windows.Forms.TextBox logFileName;
        private System.Windows.Forms.Label lblLogFileName;
        private System.Windows.Forms.FolderBrowserDialog chooseLogDirDialog;
        private System.Windows.Forms.CheckBox enableFileLog;
        private System.Windows.Forms.CheckBox enableLiveLogging;
        private System.Windows.Forms.CheckBox enableSQLite;
        private System.Windows.Forms.TextBox DBPath;
        private System.Windows.Forms.Label lblSqlitePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSqliteTableName;
        private System.Windows.Forms.TextBox DBTableName;
        private System.Windows.Forms.Button btnChooseSqlitePath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox filterExtensions;
        private System.Windows.Forms.Button btnRemoveSelectedExtension;
        private System.Windows.Forms.TextBox extensionInput;
        private System.Windows.Forms.Button btnAddExtension;
    }
}