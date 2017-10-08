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
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(507, 303);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 357);
            this.Controls.Add(this.listBox1);
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
        private System.Windows.Forms.ListBox listBox1;
    }
}

