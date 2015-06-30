using System;
using System.Diagnostics;
using System.Windows.Forms;
using Encryption;

namespace YuexiuCloud
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            loadAccountInfo();
#if DEBUG
            //txbPassword.Text = "tongbu";
            //txbUserName.Text = "tongbu";
#endif
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserMgr um = new UserMgr();
            UserMgr.UserInfo ui = um.login(txbUserName.Text, txbPassword.Text);

            if (ui.isLegalUser)
            {
                frmSetting frmStg = new frmSetting();
                if (ui.isFirstTimeLogin){
                    frmStg.Show();
                }
                else
                {
                    frmStg.Show();
                    frmStg.Hide();
                    this.Hide();
                }
                saveAccountInfo(ckbRememberAccount.Checked);
            }
            else
            {
                MessageBox.Show("登录同步盘失败，请确认用户名/密码是否正确。", "同步盘登录");
            }
        }

        // Save or clear account info
        private void saveAccountInfo(bool save)
        {
            Properties.Settings stg = new Properties.Settings();
            if (save)
            {
                string acnt = EncryptionHelper.DESEncode(txbUserName.Text.Trim(), "yuexiuCloud");
                string pswd = EncryptionHelper.DESEncode(txbPassword.Text.Trim(), txbUserName.Text.Trim());
                stg.Account = acnt + "|" + pswd;
            }
            else
            {
                stg.Account = "";
            }
            stg.Save();
        }

        private void loadAccountInfo()
        {
            Properties.Settings stg = new Properties.Settings();
            if (string.IsNullOrEmpty(stg.Account))
            {
                txbPassword.Text = "";
                txbUserName.Text = "";
            }
            else
            {
                string[] ss = stg.Account.Split('|');
                string acnt = ss[0];
                string pswd = ss[1];
                txbUserName.Text = EncryptionHelper.DESDecode(acnt, "yuexiuCloud");
                txbPassword.Text = EncryptionHelper.DESDecode(pswd, acnt);

                ckbRememberAccount.Checked = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lnkFogetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Properties.Settings stg = new Properties.Settings();
            Process.Start(stg.ForgetPasword);
        }
    }
}
