using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YuexiuCloud
{
    class NotifyIconMgr
    {
        NotifyIcon _ntfIcon;
        public NotifyIconMgr(NotifyIcon ntfIcon)
        {
            _ntfIcon = ntfIcon;
        }

        public void show()
        {
            _ntfIcon.Visible = true;
        }

        public void hide()
        {
            _ntfIcon.Visible = false;
        }

        public void popInfo(string info = null)
        {
            if (info != null)
            {
                _ntfIcon.ShowBalloonTip(2000, "越秀同步盘", info, ToolTipIcon.Info);
            }
            else
            {
                _ntfIcon.ShowBalloonTip(2000);
            }
        }
    }
}
