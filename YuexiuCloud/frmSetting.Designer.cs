namespace YuexiuCloud
{
    partial class FrmSetting
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSetting));
            this.tabAdvanceStg = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbSyncDirectionToLocal = new System.Windows.Forms.RadioButton();
            this.rdbSyncDirectionToCloud = new System.Windows.Forms.RadioButton();
            this.btnChangeSubFolder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabNormalStg = new System.Windows.Forms.TabPage();
            this.btnSelSyncFolder = new System.Windows.Forms.Button();
            this.ckbAddSyncDrive = new System.Windows.Forms.CheckBox();
            this.ckbStartWithPC = new System.Windows.Forms.CheckBox();
            this.txbSyncFolder = new System.Windows.Forms.TextBox();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveSetting = new System.Windows.Forms.Button();
            this.fdrBrwDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tabAdvanceStg.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabNormalStg.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAdvanceStg
            // 
            this.tabAdvanceStg.Controls.Add(this.groupBox1);
            this.tabAdvanceStg.Controls.Add(this.btnChangeSubFolder);
            this.tabAdvanceStg.Controls.Add(this.label3);
            this.tabAdvanceStg.Location = new System.Drawing.Point(4, 22);
            this.tabAdvanceStg.Name = "tabAdvanceStg";
            this.tabAdvanceStg.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdvanceStg.Size = new System.Drawing.Size(406, 201);
            this.tabAdvanceStg.TabIndex = 3;
            this.tabAdvanceStg.Text = "高级设置";
            this.tabAdvanceStg.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbSyncDirectionToLocal);
            this.groupBox1.Controls.Add(this.rdbSyncDirectionToCloud);
            this.groupBox1.Location = new System.Drawing.Point(21, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "同步方向";
            // 
            // rdbSyncDirectionToLocal
            // 
            this.rdbSyncDirectionToLocal.AutoSize = true;
            this.rdbSyncDirectionToLocal.Location = new System.Drawing.Point(22, 62);
            this.rdbSyncDirectionToLocal.Name = "rdbSyncDirectionToLocal";
            this.rdbSyncDirectionToLocal.Size = new System.Drawing.Size(119, 16);
            this.rdbSyncDirectionToLocal.TabIndex = 0;
            this.rdbSyncDirectionToLocal.TabStop = true;
            this.rdbSyncDirectionToLocal.Text = "由云端向本地同步";
            this.rdbSyncDirectionToLocal.UseVisualStyleBackColor = true;
            // 
            // rdbSyncDirectionToCloud
            // 
            this.rdbSyncDirectionToCloud.AutoSize = true;
            this.rdbSyncDirectionToCloud.Location = new System.Drawing.Point(22, 32);
            this.rdbSyncDirectionToCloud.Name = "rdbSyncDirectionToCloud";
            this.rdbSyncDirectionToCloud.Size = new System.Drawing.Size(119, 16);
            this.rdbSyncDirectionToCloud.TabIndex = 0;
            this.rdbSyncDirectionToCloud.TabStop = true;
            this.rdbSyncDirectionToCloud.Text = "由本地向云端同步";
            this.rdbSyncDirectionToCloud.UseVisualStyleBackColor = true;
            // 
            // btnChangeSubFolder
            // 
            this.btnChangeSubFolder.Location = new System.Drawing.Point(316, 34);
            this.btnChangeSubFolder.Name = "btnChangeSubFolder";
            this.btnChangeSubFolder.Size = new System.Drawing.Size(75, 23);
            this.btnChangeSubFolder.TabIndex = 1;
            this.btnChangeSubFolder.Text = "选择文件夹";
            this.btnChangeSubFolder.UseVisualStyleBackColor = true;
            this.btnChangeSubFolder.Click += new System.EventHandler(this.btnChangeSubFolder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "选择性同步：选择同步目录中部分文件夹为自动同步";
            // 
            // tabNormalStg
            // 
            this.tabNormalStg.Controls.Add(this.btnSelSyncFolder);
            this.tabNormalStg.Controls.Add(this.ckbAddSyncDrive);
            this.tabNormalStg.Controls.Add(this.ckbStartWithPC);
            this.tabNormalStg.Controls.Add(this.txbSyncFolder);
            this.tabNormalStg.Controls.Add(this.txbUserName);
            this.tabNormalStg.Controls.Add(this.label2);
            this.tabNormalStg.Controls.Add(this.label1);
            this.tabNormalStg.Location = new System.Drawing.Point(4, 22);
            this.tabNormalStg.Name = "tabNormalStg";
            this.tabNormalStg.Padding = new System.Windows.Forms.Padding(3);
            this.tabNormalStg.Size = new System.Drawing.Size(406, 201);
            this.tabNormalStg.TabIndex = 1;
            this.tabNormalStg.Text = "常规设置";
            this.tabNormalStg.UseVisualStyleBackColor = true;
            // 
            // btnSelSyncFolder
            // 
            this.btnSelSyncFolder.Location = new System.Drawing.Point(310, 75);
            this.btnSelSyncFolder.Name = "btnSelSyncFolder";
            this.btnSelSyncFolder.Size = new System.Drawing.Size(75, 25);
            this.btnSelSyncFolder.TabIndex = 5;
            this.btnSelSyncFolder.Text = "更改目录";
            this.btnSelSyncFolder.UseVisualStyleBackColor = true;
            this.btnSelSyncFolder.Click += new System.EventHandler(this.btnSelSyncFolder_Click);
            // 
            // ckbAddSyncDrive
            // 
            this.ckbAddSyncDrive.AutoSize = true;
            this.ckbAddSyncDrive.Location = new System.Drawing.Point(35, 155);
            this.ckbAddSyncDrive.Name = "ckbAddSyncDrive";
            this.ckbAddSyncDrive.Size = new System.Drawing.Size(252, 16);
            this.ckbAddSyncDrive.TabIndex = 4;
            this.ckbAddSyncDrive.Text = "在“我的电脑”中创建”越秀同步盘“盘符";
            this.ckbAddSyncDrive.UseVisualStyleBackColor = true;
            // 
            // ckbStartWithPC
            // 
            this.ckbStartWithPC.AutoSize = true;
            this.ckbStartWithPC.Location = new System.Drawing.Point(35, 128);
            this.ckbStartWithPC.Name = "ckbStartWithPC";
            this.ckbStartWithPC.Size = new System.Drawing.Size(132, 16);
            this.ckbStartWithPC.TabIndex = 4;
            this.ckbStartWithPC.Text = "开机启动越秀同步盘";
            this.ckbStartWithPC.UseVisualStyleBackColor = true;
            // 
            // txbSyncFolder
            // 
            this.txbSyncFolder.Location = new System.Drawing.Point(94, 77);
            this.txbSyncFolder.Name = "txbSyncFolder";
            this.txbSyncFolder.Size = new System.Drawing.Size(195, 21);
            this.txbSyncFolder.TabIndex = 3;
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(94, 36);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.ReadOnly = true;
            this.txbUserName.Size = new System.Drawing.Size(195, 21);
            this.txbUserName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "同步目录";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "帐    号";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabNormalStg);
            this.tabControl1.Controls.Add(this.tabAdvanceStg);
            this.tabControl1.Location = new System.Drawing.Point(5, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(414, 227);
            this.tabControl1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(340, 242);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveSetting
            // 
            this.btnSaveSetting.Location = new System.Drawing.Point(259, 242);
            this.btnSaveSetting.Name = "btnSaveSetting";
            this.btnSaveSetting.Size = new System.Drawing.Size(75, 25);
            this.btnSaveSetting.TabIndex = 7;
            this.btnSaveSetting.Text = "确定";
            this.btnSaveSetting.UseVisualStyleBackColor = true;
            this.btnSaveSetting.Click += new System.EventHandler(this.btnSaveSetting_Click);
            // 
            // FrmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 279);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveSetting);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSetting";
            this.Text = "越秀同步盘";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.tabAdvanceStg.ResumeLayout(false);
            this.tabAdvanceStg.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabNormalStg.ResumeLayout(false);
            this.tabNormalStg.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabAdvanceStg;
        private System.Windows.Forms.Button btnChangeSubFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabNormalStg;
        private System.Windows.Forms.Button btnSelSyncFolder;
        private System.Windows.Forms.CheckBox ckbAddSyncDrive;
        private System.Windows.Forms.CheckBox ckbStartWithPC;
        private System.Windows.Forms.TextBox txbSyncFolder;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbSyncDirectionToLocal;
        private System.Windows.Forms.RadioButton rdbSyncDirectionToCloud;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveSetting;
        private System.Windows.Forms.FolderBrowserDialog fdrBrwDialog;
    }
}

