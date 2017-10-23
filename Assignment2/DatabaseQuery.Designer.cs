namespace Assignment2 {
    partial class DatabaseQuery {
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
            this.FileEventsListView = new System.Windows.Forms.ListView();
            this.Timestamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EventType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ObjectType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.filterExtensions = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.extensionInput = new System.Windows.Forms.TextBox();
            this.btnAddExtension = new System.Windows.Forms.Button();
            this.btnRemoveSelectedExtension = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRunQuery = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.FileEventsListView.Location = new System.Drawing.Point(204, 62);
            this.FileEventsListView.Name = "FileEventsListView";
            this.FileEventsListView.Size = new System.Drawing.Size(821, 398);
            this.FileEventsListView.TabIndex = 9;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Query File Events Database";
            // 
            // filterExtensions
            // 
            this.filterExtensions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterExtensions.FormattingEnabled = true;
            this.filterExtensions.ItemHeight = 15;
            this.filterExtensions.Location = new System.Drawing.Point(7, 52);
            this.filterExtensions.Name = "filterExtensions";
            this.filterExtensions.Size = new System.Drawing.Size(170, 139);
            this.filterExtensions.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filter by Extension:";
            // 
            // extensionInput
            // 
            this.extensionInput.Location = new System.Drawing.Point(8, 201);
            this.extensionInput.Name = "extensionInput";
            this.extensionInput.Size = new System.Drawing.Size(81, 20);
            this.extensionInput.TabIndex = 2;
            // 
            // btnAddExtension
            // 
            this.btnAddExtension.Location = new System.Drawing.Point(96, 199);
            this.btnAddExtension.Name = "btnAddExtension";
            this.btnAddExtension.Size = new System.Drawing.Size(81, 23);
            this.btnAddExtension.TabIndex = 3;
            this.btnAddExtension.Text = "Add";
            this.btnAddExtension.UseVisualStyleBackColor = true;
            this.btnAddExtension.Click += new System.EventHandler(this.btnAddExtension_Click);
            // 
            // btnRemoveSelectedExtension
            // 
            this.btnRemoveSelectedExtension.Location = new System.Drawing.Point(7, 228);
            this.btnRemoveSelectedExtension.Name = "btnRemoveSelectedExtension";
            this.btnRemoveSelectedExtension.Size = new System.Drawing.Size(170, 25);
            this.btnRemoveSelectedExtension.TabIndex = 4;
            this.btnRemoveSelectedExtension.Text = "Remove Selected";
            this.btnRemoveSelectedExtension.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedExtension.Click += new System.EventHandler(this.btnRemoveSelectedExtension_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.btnRunQuery);
            this.panel1.Controls.Add(this.filterExtensions);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnRemoveSelectedExtension);
            this.panel1.Controls.Add(this.extensionInput);
            this.panel1.Controls.Add(this.btnAddExtension);
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 398);
            this.panel1.TabIndex = 11;
            // 
            // btnRunQuery
            // 
            this.btnRunQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRunQuery.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunQuery.Location = new System.Drawing.Point(8, 350);
            this.btnRunQuery.Name = "btnRunQuery";
            this.btnRunQuery.Size = new System.Drawing.Size(169, 38);
            this.btnRunQuery.TabIndex = 12;
            this.btnRunQuery.Text = "Run Query";
            this.btnRunQuery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRunQuery.UseVisualStyleBackColor = true;
            this.btnRunQuery.Click += new System.EventHandler(this.btnRunQuery_Click);
            // 
            // DatabaseQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 472);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FileEventsListView);
            this.Controls.Add(this.label1);
            this.Name = "DatabaseQuery";
            this.Text = "DatabaseQuery";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox filterExtensions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox extensionInput;
        private System.Windows.Forms.Button btnAddExtension;
        private System.Windows.Forms.Button btnRemoveSelectedExtension;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRunQuery;
    }
}