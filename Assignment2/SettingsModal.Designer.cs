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
            this.label1 = new System.Windows.Forms.Label();
            this.monitoringDir = new System.Windows.Forms.TextBox();
            this.btnChooseMonitorDir = new System.Windows.Forms.Button();
            this.includeSubdirs = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.logPath = new System.Windows.Forms.TextBox();
            this.btnChooseLogPath = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.chooseMonDirDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.logFileName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chooseLogDirDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.settingsTabs = new System.Windows.Forms.TabControl();
            this.tabPage0 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.enableFileLog = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DBPath = new System.Windows.Forms.TextBox();
            this.enableSQLite = new System.Windows.Forms.CheckBox();
            this.DBTableName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.settingsTabs.SuspendLayout();
            this.tabPage0.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monitoring Directory:";
            // 
            // monitoringDir
            // 
            this.monitoringDir.Enabled = false;
            this.monitoringDir.Location = new System.Drawing.Point(122, 10);
            this.monitoringDir.Name = "monitoringDir";
            this.monitoringDir.Size = new System.Drawing.Size(216, 20);
            this.monitoringDir.TabIndex = 1;
            // 
            // btnChooseMonitorDir
            // 
            this.btnChooseMonitorDir.Location = new System.Drawing.Point(344, 8);
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
            this.includeSubdirs.Location = new System.Drawing.Point(122, 36);
            this.includeSubdirs.Name = "includeSubdirs";
            this.includeSubdirs.Size = new System.Drawing.Size(137, 17);
            this.includeSubdirs.TabIndex = 3;
            this.includeSubdirs.Text = "Include Subdirectories?";
            this.includeSubdirs.UseVisualStyleBackColor = true;
            this.includeSubdirs.CheckedChanged += new System.EventHandler(this.includeSubdirs_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Log File Location:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // logPath
            // 
            this.logPath.Enabled = false;
            this.logPath.Location = new System.Drawing.Point(123, 42);
            this.logPath.Name = "logPath";
            this.logPath.Size = new System.Drawing.Size(216, 20);
            this.logPath.TabIndex = 5;
            // 
            // btnChooseLogPath
            // 
            this.btnChooseLogPath.Enabled = false;
            this.btnChooseLogPath.Location = new System.Drawing.Point(345, 39);
            this.btnChooseLogPath.Name = "btnChooseLogPath";
            this.btnChooseLogPath.Size = new System.Drawing.Size(75, 23);
            this.btnChooseLogPath.TabIndex = 6;
            this.btnChooseLogPath.Text = "Change";
            this.btnChooseLogPath.UseVisualStyleBackColor = true;
            this.btnChooseLogPath.Click += new System.EventHandler(this.btnChooseLogPath_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(432, 321);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Save + Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // logFileName
            // 
            this.logFileName.Enabled = false;
            this.logFileName.Location = new System.Drawing.Point(123, 68);
            this.logFileName.Name = "logFileName";
            this.logFileName.Size = new System.Drawing.Size(216, 20);
            this.logFileName.TabIndex = 9;
            this.logFileName.TextChanged += new System.EventHandler(this.logFileName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Log File Name:";
            // 
            // settingsTabs
            // 
            this.settingsTabs.Controls.Add(this.tabPage0);
            this.settingsTabs.Controls.Add(this.tabPage1);
            this.settingsTabs.Controls.Add(this.tabPage2);
            this.settingsTabs.Location = new System.Drawing.Point(12, 117);
            this.settingsTabs.Name = "settingsTabs";
            this.settingsTabs.SelectedIndex = 0;
            this.settingsTabs.Size = new System.Drawing.Size(517, 198);
            this.settingsTabs.TabIndex = 11;
            // 
            // tabPage0
            // 
            this.tabPage0.Controls.Add(this.checkBox2);
            this.tabPage0.Location = new System.Drawing.Point(4, 22);
            this.tabPage0.Name = "tabPage0";
            this.tabPage0.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage0.Size = new System.Drawing.Size(509, 172);
            this.tabPage0.TabIndex = 0;
            this.tabPage0.Text = "General";
            this.tabPage0.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.DBTableName);
            this.tabPage1.Controls.Add(this.enableSQLite);
            this.tabPage1.Controls.Add(this.DBPath);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(509, 172);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Log to SQLite";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.enableFileLog);
            this.tabPage2.Controls.Add(this.logPath);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.logFileName);
            this.tabPage2.Controls.Add(this.btnChooseLogPath);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(509, 172);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Log to File";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // enableFileLog
            // 
            this.enableFileLog.AutoSize = true;
            this.enableFileLog.Location = new System.Drawing.Point(16, 19);
            this.enableFileLog.Name = "enableFileLog";
            this.enableFileLog.Size = new System.Drawing.Size(131, 17);
            this.enableFileLog.TabIndex = 11;
            this.enableFileLog.Text = "Enable Logging to File";
            this.enableFileLog.UseVisualStyleBackColor = true;
            this.enableFileLog.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(21, 20);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(198, 17);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Log Filesystem Events as they occur";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 37);
            this.label3.TabIndex = 12;
            this.label3.Text = "Logging Options";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(11, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Path to SQLite Database File:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // DBPath
            // 
            this.DBPath.Enabled = false;
            this.DBPath.Location = new System.Drawing.Point(164, 54);
            this.DBPath.Name = "DBPath";
            this.DBPath.Size = new System.Drawing.Size(219, 20);
            this.DBPath.TabIndex = 1;
            this.DBPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // enableSQLite
            // 
            this.enableSQLite.AutoSize = true;
            this.enableSQLite.Location = new System.Drawing.Point(14, 21);
            this.enableSQLite.Name = "enableSQLite";
            this.enableSQLite.Size = new System.Drawing.Size(147, 17);
            this.enableSQLite.TabIndex = 2;
            this.enableSQLite.Text = "Enable Logging to SQLite";
            this.enableSQLite.UseVisualStyleBackColor = true;
            this.enableSQLite.CheckedChanged += new System.EventHandler(this.enableSQLite_CheckedChanged);
            // 
            // DBTableName
            // 
            this.DBTableName.Enabled = false;
            this.DBTableName.Location = new System.Drawing.Point(164, 81);
            this.DBTableName.Name = "DBTableName";
            this.DBTableName.Size = new System.Drawing.Size(219, 20);
            this.DBTableName.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(11, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Database Table Name:";
            // 
            // SettingsModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 353);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.settingsTabs);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.includeSubdirs);
            this.Controls.Add(this.btnChooseMonitorDir);
            this.Controls.Add(this.monitoringDir);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsModal";
            this.Text = "Settings";
            this.settingsTabs.ResumeLayout(false);
            this.tabPage0.ResumeLayout(false);
            this.tabPage0.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox monitoringDir;
        private System.Windows.Forms.Button btnChooseMonitorDir;
        private System.Windows.Forms.CheckBox includeSubdirs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox logPath;
        private System.Windows.Forms.Button btnChooseLogPath;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FolderBrowserDialog chooseMonDirDialog;
        private System.Windows.Forms.TextBox logFileName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog chooseLogDirDialog;
        private System.Windows.Forms.TabControl settingsTabs;
        private System.Windows.Forms.TabPage tabPage0;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox enableFileLog;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox enableSQLite;
        private System.Windows.Forms.TextBox DBPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DBTableName;
    }
}