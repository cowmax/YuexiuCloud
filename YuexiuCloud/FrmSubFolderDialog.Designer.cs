namespace YuexiuCloud
{
    partial class FrmSubFolderDialog
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
            this.folderTree = new MyTreeView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveSubFolders = new System.Windows.Forms.Button();
            this.ckbSelectAll = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // folderTree
            // 
            this.folderTree.CheckBoxes = true;
            this.folderTree.Location = new System.Drawing.Point(12, 44);
            this.folderTree.Name = "folderTree";
            this.folderTree.Size = new System.Drawing.Size(282, 214);
            this.folderTree.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(131, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveSubFolders
            // 
            this.btnSaveSubFolders.Location = new System.Drawing.Point(219, 287);
            this.btnSaveSubFolders.Name = "btnSaveSubFolders";
            this.btnSaveSubFolders.Size = new System.Drawing.Size(75, 30);
            this.btnSaveSubFolders.TabIndex = 2;
            this.btnSaveSubFolders.Text = "确 定";
            this.btnSaveSubFolders.UseVisualStyleBackColor = true;
            this.btnSaveSubFolders.Click += new System.EventHandler(this.btnSaveSubFolders_Click);
            // 
            // ckbSelectAll
            // 
            this.ckbSelectAll.AutoSize = true;
            this.ckbSelectAll.Location = new System.Drawing.Point(13, 265);
            this.ckbSelectAll.Name = "ckbSelectAll";
            this.ckbSelectAll.Size = new System.Drawing.Size(48, 16);
            this.ckbSelectAll.TabIndex = 3;
            this.ckbSelectAll.Text = "全选";
            this.ckbSelectAll.UseVisualStyleBackColor = true;
            this.ckbSelectAll.CheckedChanged += new System.EventHandler(this.ckbSelectAll_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "请选择需要自动同步的子文件夹";
            // 
            // FrmSubFolderDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 328);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckbSelectAll);
            this.Controls.Add(this.btnSaveSubFolders);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.folderTree);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSubFolderDialog";
            this.Text = "选择同步子文件夹";
            this.Load += new System.EventHandler(this.FrmSubFolderDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView folderTree;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveSubFolders;
        private System.Windows.Forms.CheckBox ckbSelectAll;
        private System.Windows.Forms.Label label1;
    }
}