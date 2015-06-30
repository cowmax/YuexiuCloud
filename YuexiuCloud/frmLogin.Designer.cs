namespace YuexiuCloud
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ckbRememberAccount = new System.Windows.Forms.CheckBox();
            this.lnkFogetPassword = new System.Windows.Forms.LinkLabel();
            this.ntficonYuexiuCloud = new System.Windows.Forms.NotifyIcon(this.components);
            this.muStripYuexiu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miOpenLocalFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenWebSite = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenRecycleBin = new System.Windows.Forms.ToolStripMenuItem();
            this.toooooooooo4 = new System.Windows.Forms.ToolStripSeparator();
            this.miBrowseSyncState = new System.Windows.Forms.ToolStripMenuItem();
            this.miStartSync = new System.Windows.Forms.ToolStripMenuItem();
            this.miPauseSync = new System.Windows.Forms.ToolStripMenuItem();
            this.miShutdownPC = new System.Windows.Forms.ToolStripMenuItem();
            this.toooooooooo3 = new System.Windows.Forms.ToolStripSeparator();
            this.miBrowseBackupState = new System.Windows.Forms.ToolStripMenuItem();
            this.miBrowseBackupFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toooooooooo2 = new System.Windows.Forms.ToolStripSeparator();
            this.miShowSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toooooooooo1 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.muStripYuexiu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "密  码";
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(113, 44);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(158, 21);
            this.txbUserName.TabIndex = 1;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(113, 83);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(158, 21);
            this.txbPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(113, 126);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 25);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "登 录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(196, 126);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ckbRememberAccount
            // 
            this.ckbRememberAccount.AutoSize = true;
            this.ckbRememberAccount.Location = new System.Drawing.Point(113, 168);
            this.ckbRememberAccount.Name = "ckbRememberAccount";
            this.ckbRememberAccount.Size = new System.Drawing.Size(72, 16);
            this.ckbRememberAccount.TabIndex = 5;
            this.ckbRememberAccount.Text = "记住密码";
            this.ckbRememberAccount.UseVisualStyleBackColor = true;
            // 
            // lnkFogetPassword
            // 
            this.lnkFogetPassword.AutoSize = true;
            this.lnkFogetPassword.Location = new System.Drawing.Point(261, 172);
            this.lnkFogetPassword.Name = "lnkFogetPassword";
            this.lnkFogetPassword.Size = new System.Drawing.Size(95, 12);
            this.lnkFogetPassword.TabIndex = 6;
            this.lnkFogetPassword.TabStop = true;
            this.lnkFogetPassword.Text = "我忘记了密码...";
            this.lnkFogetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFogetPassword_LinkClicked);
            // 
            // ntficonYuexiuCloud
            // 
            this.ntficonYuexiuCloud.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ntficonYuexiuCloud.BalloonTipText = "双击打开本地同步盘";
            this.ntficonYuexiuCloud.BalloonTipTitle = "越秀同步盘";
            this.ntficonYuexiuCloud.ContextMenuStrip = this.muStripYuexiu;
            this.ntficonYuexiuCloud.Icon = ((System.Drawing.Icon)(resources.GetObject("ntficonYuexiuCloud.Icon")));
            this.ntficonYuexiuCloud.Text = "越秀云盘";
            // 
            // muStripYuexiu
            // 
            this.muStripYuexiu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpenLocalFolder,
            this.miOpenWebSite,
            this.miOpenRecycleBin,
            this.toooooooooo4,
            this.miBrowseSyncState,
            this.miStartSync,
            this.miPauseSync,
            this.miShutdownPC,
            this.toooooooooo3,
            this.miBrowseBackupState,
            this.miBrowseBackupFolder,
            this.toooooooooo2,
            this.miShowSetting,
            this.miHelp,
            this.toooooooooo1,
            this.miExit});
            this.muStripYuexiu.Name = "muStripYuexiu";
            this.muStripYuexiu.Size = new System.Drawing.Size(173, 314);
            this.muStripYuexiu.Text = "越秀同步盘功能菜单";
            // 
            // miOpenLocalFolder
            // 
            this.miOpenLocalFolder.Name = "miOpenLocalFolder";
            this.miOpenLocalFolder.Size = new System.Drawing.Size(172, 22);
            this.miOpenLocalFolder.Text = "打开越秀同步盘";
            // 
            // miOpenWebSite
            // 
            this.miOpenWebSite.Name = "miOpenWebSite";
            this.miOpenWebSite.Size = new System.Drawing.Size(172, 22);
            this.miOpenWebSite.Text = "打开越秀云盘首页";
            // 
            // miOpenRecycleBin
            // 
            this.miOpenRecycleBin.Name = "miOpenRecycleBin";
            this.miOpenRecycleBin.Size = new System.Drawing.Size(172, 22);
            this.miOpenRecycleBin.Text = "打开回收站";
            // 
            // toooooooooo4
            // 
            this.toooooooooo4.Name = "toooooooooo4";
            this.toooooooooo4.Size = new System.Drawing.Size(169, 6);
            // 
            // miBrowseSyncState
            // 
            this.miBrowseSyncState.Name = "miBrowseSyncState";
            this.miBrowseSyncState.Size = new System.Drawing.Size(172, 22);
            this.miBrowseSyncState.Text = "查看同步状态";
            // 
            // miStartSync
            // 
            this.miStartSync.Name = "miStartSync";
            this.miStartSync.Size = new System.Drawing.Size(172, 22);
            this.miStartSync.Text = "立即同步";
            // 
            // miPauseSync
            // 
            this.miPauseSync.Name = "miPauseSync";
            this.miPauseSync.Size = new System.Drawing.Size(172, 22);
            this.miPauseSync.Text = "暂停同步";
            // 
            // miShutdownPC
            // 
            this.miShutdownPC.Name = "miShutdownPC";
            this.miShutdownPC.Size = new System.Drawing.Size(172, 22);
            this.miShutdownPC.Text = "同步完成后关机";
            // 
            // toooooooooo3
            // 
            this.toooooooooo3.Name = "toooooooooo3";
            this.toooooooooo3.Size = new System.Drawing.Size(169, 6);
            // 
            // miBrowseBackupState
            // 
            this.miBrowseBackupState.Name = "miBrowseBackupState";
            this.miBrowseBackupState.Size = new System.Drawing.Size(172, 22);
            this.miBrowseBackupState.Text = "查看备份状态";
            // 
            // miBrowseBackupFolder
            // 
            this.miBrowseBackupFolder.Name = "miBrowseBackupFolder";
            this.miBrowseBackupFolder.Size = new System.Drawing.Size(172, 22);
            this.miBrowseBackupFolder.Text = "查看我的备份文件";
            // 
            // toooooooooo2
            // 
            this.toooooooooo2.Name = "toooooooooo2";
            this.toooooooooo2.Size = new System.Drawing.Size(169, 6);
            // 
            // miShowSetting
            // 
            this.miShowSetting.Name = "miShowSetting";
            this.miShowSetting.Size = new System.Drawing.Size(172, 22);
            this.miShowSetting.Text = "设置";
            this.miShowSetting.Click += new System.EventHandler(this.miShowSetting_Click);
            // 
            // miHelp
            // 
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(172, 22);
            this.miHelp.Text = "帮助";
            // 
            // toooooooooo1
            // 
            this.toooooooooo1.Name = "toooooooooo1";
            this.toooooooooo1.Size = new System.Drawing.Size(169, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(172, 22);
            this.miExit.Text = "退出";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 206);
            this.Controls.Add(this.lnkFogetPassword);
            this.Controls.Add(this.ckbRememberAccount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.Text = "越秀云盘";
            this.muStripYuexiu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox ckbRememberAccount;
        private System.Windows.Forms.LinkLabel lnkFogetPassword;
        private System.Windows.Forms.NotifyIcon ntficonYuexiuCloud;
        private System.Windows.Forms.ContextMenuStrip muStripYuexiu;
        private System.Windows.Forms.ToolStripMenuItem miOpenLocalFolder;
        private System.Windows.Forms.ToolStripMenuItem miOpenWebSite;
        private System.Windows.Forms.ToolStripMenuItem miOpenRecycleBin;
        private System.Windows.Forms.ToolStripSeparator toooooooooo4;
        private System.Windows.Forms.ToolStripMenuItem miBrowseSyncState;
        private System.Windows.Forms.ToolStripMenuItem miStartSync;
        private System.Windows.Forms.ToolStripMenuItem miPauseSync;
        private System.Windows.Forms.ToolStripMenuItem miShutdownPC;
        private System.Windows.Forms.ToolStripSeparator toooooooooo3;
        private System.Windows.Forms.ToolStripMenuItem miBrowseBackupState;
        private System.Windows.Forms.ToolStripMenuItem miBrowseBackupFolder;
        private System.Windows.Forms.ToolStripSeparator toooooooooo2;
        private System.Windows.Forms.ToolStripMenuItem miShowSetting;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.ToolStripSeparator toooooooooo1;
        private System.Windows.Forms.ToolStripMenuItem miExit;
    }
}