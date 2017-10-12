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
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.chooseMonDirDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.logFileName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chooseLogDirDialog = new System.Windows.Forms.FolderBrowserDialog();
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
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Log File Location:";
            // 
            // logPath
            // 
            this.logPath.Enabled = false;
            this.logPath.Location = new System.Drawing.Point(122, 75);
            this.logPath.Name = "logPath";
            this.logPath.Size = new System.Drawing.Size(216, 20);
            this.logPath.TabIndex = 5;
            // 
            // btnChooseLogPath
            // 
            this.btnChooseLogPath.Location = new System.Drawing.Point(344, 73);
            this.btnChooseLogPath.Name = "btnChooseLogPath";
            this.btnChooseLogPath.Size = new System.Drawing.Size(75, 23);
            this.btnChooseLogPath.TabIndex = 6;
            this.btnChooseLogPath.Text = "Change";
            this.btnChooseLogPath.UseVisualStyleBackColor = true;
            this.btnChooseLogPath.Click += new System.EventHandler(this.btnChooseLogPath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Note: Changing these values will restart the monitoring";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(322, 170);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Save + Continue";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // logFileName
            // 
            this.logFileName.Location = new System.Drawing.Point(122, 101);
            this.logFileName.Name = "logFileName";
            this.logFileName.Size = new System.Drawing.Size(216, 20);
            this.logFileName.TabIndex = 9;
            this.logFileName.TextChanged += new System.EventHandler(this.logFileName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Log File Name:";
            // 
            // SettingsModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 209);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.logFileName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnChooseLogPath);
            this.Controls.Add(this.logPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.includeSubdirs);
            this.Controls.Add(this.btnChooseMonitorDir);
            this.Controls.Add(this.monitoringDir);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsModal";
            this.Text = "Settings";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FolderBrowserDialog chooseMonDirDialog;
        private System.Windows.Forms.TextBox logFileName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog chooseLogDirDialog;
    }
}