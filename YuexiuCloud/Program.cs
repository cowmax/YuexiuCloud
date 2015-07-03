using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YuexiuCloud
{
    static class Program
    {
        public static FrmLogin frmLogin = null;
        public static FrmSetting frmSetting = null;
        public static WebClient _wc = null;
        public static string _cookie = null;
        public static FileMgr _fileMgr = null;
        public static UserMgr _userMgr = null;

        public static UserMgr getUserMgr()
        {
            if (_userMgr == null) _userMgr = new UserMgr();
            return _userMgr;
        }

        public static FileMgr getFileMgr()
        {
            if (_fileMgr == null)
            {
                Properties.Settings stg = new Properties.Settings();
                _fileMgr = new FileMgr(stg.SyncFolder);
            }
            return _fileMgr;
        }

        public static WebClient getWebClient()
        {
            if (_wc == null)
            {
                _wc = new WebClient();
            }
            else // Update cookie
            {
                if (_wc.ResponseHeaders.AllKeys.Contains("Set-Cookie"))
                {
                    _cookie = _wc.ResponseHeaders["Set-Cookie"];
                }
            }

            _wc.Headers.Clear();
            _wc.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
            _wc.Headers.Add(HttpRequestHeader.Accept, "application/json, text/javascript, */*; q=0.01");
            _wc.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip, deflate");
            _wc.Headers.Add(HttpRequestHeader.AcceptLanguage, "zh-CN,zh;q=0.8,en;q=0.6,zh-TW;q=0.4");

            if (_cookie != null)
            {
                _wc.Headers.Add(HttpRequestHeader.Cookie, _cookie);
            }

            return _wc;
        }

        public static string getCookie()
        {
            if (_cookie == null) _cookie = "";
            return _cookie;
        }

        public static FrmLogin getLoginForm()
        {
            frmLogin = new FrmLogin();
            return frmLogin;
        }

        public static FrmSetting getSettingForm()
        {
            frmSetting = new FrmSetting();
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
