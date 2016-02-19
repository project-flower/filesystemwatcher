namespace filesystemwatcher
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxDirectory = new System.Windows.Forms.ComboBox();
            this.checkBoxEnabled = new System.Windows.Forms.CheckBox();
            this.textBoxLogs = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.checkBoxSubDirectory = new System.Windows.Forms.CheckBox();
            this.checkBoxDesc = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDirectory
            // 
            this.comboBoxDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDirectory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxDirectory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.comboBoxDirectory.FormattingEnabled = true;
            this.comboBoxDirectory.Location = new System.Drawing.Point(12, 12);
            this.comboBoxDirectory.Name = "comboBoxDirectory";
            this.comboBoxDirectory.Size = new System.Drawing.Size(276, 20);
            this.comboBoxDirectory.TabIndex = 0;
            this.comboBoxDirectory.TextChanged += new System.EventHandler(this.comboBoxDirectory_TextChanged);
            // 
            // checkBoxEnabled
            // 
            this.checkBoxEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxEnabled.AutoSize = true;
            this.checkBoxEnabled.Location = new System.Drawing.Point(209, 38);
            this.checkBoxEnabled.Name = "checkBoxEnabled";
            this.checkBoxEnabled.Size = new System.Drawing.Size(79, 16);
            this.checkBoxEnabled.TabIndex = 1;
            this.checkBoxEnabled.Text = "Enabled(&E)";
            this.checkBoxEnabled.UseVisualStyleBackColor = true;
            this.checkBoxEnabled.CheckedChanged += new System.EventHandler(this.checkBoxEnabled_CheckedChanged);
            // 
            // textBoxLogs
            // 
            this.textBoxLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogs.Location = new System.Drawing.Point(12, 60);
            this.textBoxLogs.Multiline = true;
            this.textBoxLogs.Name = "textBoxLogs";
            this.textBoxLogs.ReadOnly = true;
            this.textBoxLogs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLogs.Size = new System.Drawing.Size(276, 206);
            this.textBoxLogs.TabIndex = 2;
            this.textBoxLogs.WordWrap = false;
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.IncludeSubdirectories = true;
            this.fileSystemWatcher.SynchronizingObject = this;
            this.fileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Modified);
            this.fileSystemWatcher.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Modified);
            this.fileSystemWatcher.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Modified);
            this.fileSystemWatcher.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher_Renamed);
            // 
            // checkBoxSubDirectory
            // 
            this.checkBoxSubDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSubDirectory.AutoSize = true;
            this.checkBoxSubDirectory.Location = new System.Drawing.Point(85, 38);
            this.checkBoxSubDirectory.Name = "checkBoxSubDirectory";
            this.checkBoxSubDirectory.Size = new System.Drawing.Size(118, 16);
            this.checkBoxSubDirectory.TabIndex = 3;
            this.checkBoxSubDirectory.Text = "Sub Directories(&S)";
            this.checkBoxSubDirectory.UseVisualStyleBackColor = true;
            this.checkBoxSubDirectory.CheckedChanged += new System.EventHandler(this.checkBoxSubDirectory_CheckedChanged);
            // 
            // checkBoxDesc
            // 
            this.checkBoxDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxDesc.AutoSize = true;
            this.checkBoxDesc.Checked = true;
            this.checkBoxDesc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDesc.Location = new System.Drawing.Point(222, 272);
            this.checkBoxDesc.Name = "checkBoxDesc";
            this.checkBoxDesc.Size = new System.Drawing.Size(66, 16);
            this.checkBoxDesc.TabIndex = 4;
            this.checkBoxDesc.Text = "Desc(&D)";
            this.checkBoxDesc.UseVisualStyleBackColor = true;
            this.checkBoxDesc.CheckedChanged += new System.EventHandler(this.checkBoxDesc_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.checkBoxDesc);
            this.Controls.Add(this.checkBoxSubDirectory);
            this.Controls.Add(this.textBoxLogs);
            this.Controls.Add(this.checkBoxEnabled);
            this.Controls.Add(this.comboBoxDirectory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "File System Watcher";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDirectory;
        private System.Windows.Forms.CheckBox checkBoxEnabled;
        private System.Windows.Forms.TextBox textBoxLogs;
        private System.IO.FileSystemWatcher fileSystemWatcher;
        private System.Windows.Forms.CheckBox checkBoxDesc;
        private System.Windows.Forms.CheckBox checkBoxSubDirectory;
    }
}

