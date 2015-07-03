using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using Encryption;

namespace YuexiuCloud
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
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
            UserMgr um = Program.getUserMgr();
            LoginResult result = um.login(txbUserName.Text, txbPassword.Text);

            if (result.ui.isLegalUser)
            {
                increaseLoginTimes();
                this.Hide();
                if (isFirstTimeLogin())
                {
                    FrmSetting frmStg = Program.getSettingForm();
                    frmStg.Show();
                }
                else
                {
                    NotifyIconMgr ntfIcon = new NotifyIconMgr(ntficonYuexiuCloud);
                    ntfIcon.show();
                }
                saveAccountInfo(ckbRememberAccount.Checked);
            }
            else
            {
                MessageBox.Show("登录同步盘失败，请确认用户名/密码是否正确。", "同步盘登录");
            }
        }

        private int increaseLoginTimes()
        {
            Properties.Settings stg = new Properties.Settings();
            int t = int.Parse(stg.LoginTimes);
            stg.LoginTimes = (++t).ToString();
            stg.Save();
            return t;
        }

        private bool isFirstTimeLogin()
        {
            Properties.Settings stg = new Properties.Settings();
            int t = int.Parse(stg.LoginTimes);

            return (t == 1);
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

        private void miExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("关闭同步盘后，本地文件下云盘将不能保持同步\n确定要退出吗？", "退出同步盘", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
                Program.frmLogin.Close();
            }
        }

        private void miShowSetting_Click(object sender, EventArgs e)
        {
            FrmSetting frm = Program.getSettingForm();
            frm.Show();
        }
    }
}
