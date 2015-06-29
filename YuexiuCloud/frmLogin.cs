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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

#if DEBUG
            txbPassword.Text = "tongbu";
            txbUserName.Text = "tongbu";
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
                    frmStg.Hide();
                }
            }
            else
            {
                MessageBox.Show("登录同步盘失败，请确认用户名/密码是否正确。", "同步盘登录");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
