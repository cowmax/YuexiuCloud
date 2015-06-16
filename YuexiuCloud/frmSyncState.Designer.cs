namespace YuexiuCloud
{
    partial class frmSyncState
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSyncState));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSyncState = new System.Windows.Forms.TabPage();
            this.tabBackup = new System.Windows.Forms.TabPage();
            this.lsvSyncState = new System.Windows.Forms.ListView();
            this.lsvBackup = new System.Windows.Forms.ListView();
            this.hdrSyncState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrSyncName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrSyncProgress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrBakState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrBakName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrBakProgress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabSyncState.SuspendLayout();
            this.tabBackup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSyncState);
            this.tabControl1.Controls.Add(this.tabBackup);
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 25);
            this.tabControl1.Location = new System.Drawing.Point(4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(536, 339);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSyncState
            // 
            this.tabSyncState.Controls.Add(this.lsvSyncState);
            this.tabSyncState.Location = new System.Drawing.Point(4, 29);
            this.tabSyncState.Name = "tabSyncState";
            this.tabSyncState.Padding = new System.Windows.Forms.Padding(3);
            this.tabSyncState.Size = new System.Drawing.Size(528, 306);
            this.tabSyncState.TabIndex = 0;
            this.tabSyncState.Text = "同步列表";
            this.tabSyncState.UseVisualStyleBackColor = true;
            // 
            // tabBackup
            // 
            this.tabBackup.Controls.Add(this.lsvBackup);
            this.tabBackup.Location = new System.Drawing.Point(4, 29);
            this.tabBackup.Name = "tabBackup";
            this.tabBackup.Padding = new System.Windows.Forms.Padding(3);
            this.tabBackup.Size = new System.Drawing.Size(528, 306);
            this.tabBackup.TabIndex = 1;
            this.tabBackup.Text = "备份列表";
            this.tabBackup.UseVisualStyleBackColor = true;
            // 
            // lsvSyncState
            // 
            this.lsvSyncState.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdrSyncState,
            this.hdrSyncName,
            this.hdrSyncProgress});
            this.lsvSyncState.Location = new System.Drawing.Point(6, 6);
            this.lsvSyncState.Name = "lsvSyncState";
            this.lsvSyncState.Size = new System.Drawing.Size(519, 304);
            this.lsvSyncState.TabIndex = 0;
            this.lsvSyncState.UseCompatibleStateImageBehavior = false;
            // 
            // lsvBackup
            // 
            this.lsvBackup.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdrBakState,
            this.hdrBakName,
            this.hdrBakProgress});
            this.lsvBackup.Location = new System.Drawing.Point(6, 6);
            this.lsvBackup.Name = "lsvBackup";
            this.lsvBackup.Size = new System.Drawing.Size(516, 298);
            this.lsvBackup.TabIndex = 0;
            this.lsvBackup.UseCompatibleStateImageBehavior = false;
            // 
            // hdrSyncState
            // 
            this.hdrSyncState.Text = "状态";
            // 
            // hdrSyncName
            // 
            this.hdrSyncName.Text = "名称";
            // 
            // hdrSyncProgress
            // 
            this.hdrSyncProgress.Text = "进度";
            // 
            // hdrBakState
            // 
            this.hdrBakState.Text = "状态";
            // 
            // hdrBakName
            // 
            this.hdrBakName.Text = "名称";
            // 
            // hdrBakProgress
            // 
            this.hdrBakProgress.Text = "进度";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "清空历史记录";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(102, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "查看备份文件";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmSyncState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 380);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSyncState";
            this.Text = "同步/备份状态";
            this.tabControl1.ResumeLayout(false);
            this.tabSyncState.ResumeLayout(false);
            this.tabBackup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSyncState;
        private System.Windows.Forms.ListView lsvSyncState;
        private System.Windows.Forms.TabPage tabBackup;
        private System.Windows.Forms.ListView lsvBackup;
        private System.Windows.Forms.ColumnHeader hdrSyncState;
        private System.Windows.Forms.ColumnHeader hdrSyncName;
        private System.Windows.Forms.ColumnHeader hdrSyncProgress;
        private System.Windows.Forms.ColumnHeader hdrBakState;
        private System.Windows.Forms.ColumnHeader hdrBakName;
        private System.Windows.Forms.ColumnHeader hdrBakProgress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}