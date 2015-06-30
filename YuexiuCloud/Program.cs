using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YuexiuCloud
{
    static class Program
    {
        public static FrmLogin frmLogin = null;
        public static FrmSetting frmSetting = null;

        public static FrmLogin getLoginForm()
        {
            if (frmLogin == null)
            {
                frmLogin = new FrmLogin();
            }
            return frmLogin;
        }

        public static FrmSetting getSettingForm()
        {
            if (frmSetting == null)
            {
                frmSetting = new FrmSetting();
            }
            return frmSetting;
        }
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(getLoginForm());
        }
    }
}
