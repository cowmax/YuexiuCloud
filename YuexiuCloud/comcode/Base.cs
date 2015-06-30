using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuexiuCloud
{
    public abstract class ResultBase
    {
        public string code;
        public string msg;
    }

    public class LoginResult
    {
        public string code;
        public string msg;
        public UserMgr.UserInfo ui;
    }

}
