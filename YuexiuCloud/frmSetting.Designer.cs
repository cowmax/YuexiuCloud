﻿namespace YuexiuCloud
{
    partial class frmSetting
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetting));
            this.tabAdvanceStg = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabNormalStg = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ntficonYuexiuCloud = new System.Windows.Forms.NotifyIcon(this.components);
            this.muStripYuexiu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miOpenLocalFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenWebSite = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenRecycleBin = new System.Windows.Forms.ToolStripMenuItem();
            this.miBrowseSyncState = new System.Windows.Forms.ToolStripMenuItem();
            this.miStartSync = new System.Windows.Forms.ToolStripMenuItem();
            this.miPauseSync = new System.Windows.Forms.ToolStripMenuItem();
            this.miShutdownPC = new System.Windows.Forms.ToolStripMenuItem();
            this.miBrowseBackupState = new System.Windows.Forms.ToolStripMenuItem();
            this.miBrowseBackupFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.miShowSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toooooooooo1 = new System.Windows.Forms.ToolStripSeparator();
            this.toooooooooo2 = new System.Windows.Forms.ToolStripSeparator();
            this.toooooooooo3 = new System.Windows.Forms.ToolStripSeparator();
            this.toooooooooo4 = new System.Windows.Forms.ToolStripSeparator();
            this.tabAdvanceStg.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabNormalStg.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.muStripYuexiu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAdvanceStg
            // 
            this.tabAdvanceStg.Controls.Add(this.groupBox1);
            this.tabAdvanceStg.Controls.Add(this.button4);
            this.tabAdvanceStg.Controls.Add(this.label3);
            this.tabAdvanceStg.Location = new System.Drawing.Point(4, 22);
            this.tabAdvanceStg.Name = "tabAdvanceStg";
            this.tabAdvanceStg.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdvanceStg.Size = new System.Drawing.Size(406, 248);
            this.tabAdvanceStg.TabIndex = 3;
            this.tabAdvanceStg.Text = "高级设置";
            this.tabAdvanceStg.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(21, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "同步方向";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(22, 62);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(119, 16);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "由云端向本地同步";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(22, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(119, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "由本地向云端同步";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(316, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "选择文件夹";
            this.button4.UseVisualStyleBackColor = true;
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
            this.tabNormalStg.Controls.Add(this.button3);
            this.tabNormalStg.Controls.Add(this.button2);
            this.tabNormalStg.Controls.Add(this.button1);
            this.tabNormalStg.Controls.Add(this.checkBox3);
            this.tabNormalStg.Controls.Add(this.checkBox1);
            this.tabNormalStg.Controls.Add(this.textBox1);
            this.tabNormalStg.Controls.Add(this.txbUserName);
            this.tabNormalStg.Controls.Add(this.label2);
            this.tabNormalStg.Controls.Add(this.label1);
            this.tabNormalStg.Location = new System.Drawing.Point(4, 22);
            this.tabNormalStg.Name = "tabNormalStg";
            this.tabNormalStg.Padding = new System.Windows.Forms.Padding(3);
            this.tabNormalStg.Size = new System.Drawing.Size(406, 248);
            this.tabNormalStg.TabIndex = 1;
            this.tabNormalStg.Text = "常规设置";
            this.tabNormalStg.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(310, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 25);
            this.button3.TabIndex = 5;
            this.button3.Text = "取消";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "确定";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "更改目录";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(35, 155);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(252, 16);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "在“我的电脑”中创建”越秀同步盘“盘符";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(35, 128);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(132, 16);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "开机启动越秀同步盘";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 21);
            this.textBox1.TabIndex = 3;
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(94, 36);
            this.txbUserName.Name = "txbUserName";
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
            this.tabControl1.Size = new System.Drawing.Size(414, 274);
            this.tabControl1.TabIndex = 0;
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
            // miShowSetting
            // 
            this.miShowSetting.Name = "miShowSetting";
            this.miShowSetting.Size = new System.Drawing.Size(172, 22);
            this.miShowSetting.Text = "设置";
            // 
            // miHelp
            // 
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(172, 22);
            this.miHelp.Text = "帮助";
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(172, 22);
            this.miExit.Text = "退出";
            // 
            // toooooooooo1
            // 
            this.toooooooooo1.Name = "toooooooooo1";
            this.toooooooooo1.Size = new System.Drawing.Size(169, 6);
            // 
            // toooooooooo2
            // 
            this.toooooooooo2.Name = "toooooooooo2";
            this.toooooooooo2.Size = new System.Drawing.Size(169, 6);
            // 
            // toooooooooo3
            // 
            this.toooooooooo3.Name = "toooooooooo3";
            this.toooooooooo3.Size = new System.Drawing.Size(169, 6);
            // 
            // toooooooooo4
            // 
            this.toooooooooo4.Name = "toooooooooo4";
            this.toooooooooo4.Size = new System.Drawing.Size(169, 6);
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 279);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetting";
            this.Text = "越秀同步盘";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.tabAdvanceStg.ResumeLayout(false);
            this.tabAdvanceStg.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabNormalStg.ResumeLayout(false);
            this.tabNormalStg.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.muStripYuexiu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabAdvanceStg;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabNormalStg;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.NotifyIcon ntficonYuexiuCloud;

        private System.Windows.Forms.ContextMenuStrip muStripYuexiu;
        private System.Windows.Forms.ToolStripMenuItem miOpenLocalFolder;
        private System.Windows.Forms.ToolStripMenuItem miOpenWebSite;
        private System.Windows.Forms.ToolStripMenuItem miOpenRecycleBin;
        private System.Windows.Forms.ToolStripMenuItem miBrowseSyncState;
        private System.Windows.Forms.ToolStripMenuItem miStartSync;
        private System.Windows.Forms.ToolStripMenuItem miPauseSync;
        private System.Windows.Forms.ToolStripMenuItem miShutdownPC;
        private System.Windows.Forms.ToolStripMenuItem miBrowseBackupState;
        private System.Windows.Forms.ToolStripMenuItem miBrowseBackupFolder;
        private System.Windows.Forms.ToolStripMenuItem miShowSetting;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripSeparator toooooooooo4;
        private System.Windows.Forms.ToolStripSeparator toooooooooo3;
        private System.Windows.Forms.ToolStripSeparator toooooooooo2;
        private System.Windows.Forms.ToolStripSeparator toooooooooo1;
    }
}

