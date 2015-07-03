using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YuexiuCloud
{
    public partial class FrmSetting : Form
    {
        SettingMgr _StgMgr = new SettingMgr();

        public FrmSetting()
        {
            InitializeComponent();
            
        }

        private bool loadSettings()
        {
            bool bSucc = false;
            UserMgr um = Program.getUserMgr();
            Properties.Settings stg = new Properties.Settings();

            if (um.UserName != stg.UserName || string.IsNullOrEmpty(stg.UserName))
            {
                bSucc = loadDefaultSettings();
            }
            else
            {
                txbUserName.Text = stg.UserName;
                txbSyncFolder.Text = stg.SyncFolder;
                ckbStartWithPC.Checked = bool.Parse(stg.StartWithPC);
                ckbAddSyncDrive.Checked = bool.Parse(stg.addSyncDrive);
                if (stg.SyncDirection == "toCloud")
                {
                    rdbSyncDirectionToCloud.Checked = true;
                    rdbSyncDirectionToLocal.Checked = false;
                }
                else
                {
                    rdbSyncDirectionToCloud.Checked = false;
                    rdbSyncDirectionToLocal.Checked = true;
                }
                bSucc = true;
            }
            return bSucc;
        }

        private bool loadDefaultSettings()
        {
            UserMgr um = Program.getUserMgr();

            txbUserName.Text = um.UserName;
            txbSyncFolder.Text = "";
            ckbStartWithPC.Checked = true;
            ckbAddSyncDrive.Checked = true;

            rdbSyncDirectionToCloud.Checked = true;
            rdbSyncDirectionToLocal.Checked = false;

            return true;
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            if (loadSettings())
            {

            }
            else
            {

            }
        }

        private void btnSaveSetting_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelSyncFolder_Click(object sender, EventArgs e)
        {
            fdrBrwDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            fdrBrwDialog.Description = "请选择本地同步目录";
            if (fdrBrwDialog.ShowDialog() == DialogResult.OK)
            {
                txbSyncFolder.Text = fdrBrwDialog.SelectedPath;
            }
            else
            {
                // do nothing.
            }
        }

        private void btnChangeSubFolder_Click(object sender, EventArgs e)
        {
            FrmSubFolderDialog frm = new FrmSubFolderDialog();
            frm.ShowDialog();
        }
    }
}
