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

        private void init()
        {
            string currUser = getCurrentUser();
            _StgMgr.Add(new SettingItem("userName", currUser, currUser.GetType(), 0, DateTime.Now));
            _StgMgr.Add(new SettingItem("syncFolder", , string, 0, DateTime.Now));
            _StgMgr.Add(new SettingItem("startWithPc", , bool, 0, DateTime.Now));
            _StgMgr.Add(new SettingItem("addSyncDrive", , bool, 0, DateTime.Now));
            _StgMgr.Add(new SettingItem("syncDirection", , int, 0, DateTime.Now));
            _StgMgr.Add(new SettingItem("changeSubFolder", , int, 0, DateTime.Now));
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveSetting_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
