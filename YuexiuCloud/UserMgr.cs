using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using ComCode;

namespace YuexiuCloud
{
    class UserMgr
    {
        WebClient _wc = null;

        public UserMgr()
        {

        }

        internal WebClient  getWebClient()
        {
            string cookie = null;
            if (_wc == null) _wc = new WebClient();
            else cookie = _wc.ResponseHeaders["Set-Cookie"];
            
            _wc.Headers.Clear();
            _wc.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
            _wc.Headers.Add(HttpRequestHeader.Accept, "application/json, text/javascript, */*; q=0.01");
            _wc.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip, deflate");
            _wc.Headers.Add(HttpRequestHeader.AcceptLanguage, "zh-CN,zh;q=0.8,en;q=0.6,zh-TW;q=0.4");

            if (cookie != null)
            {
                _wc.Headers.Add(HttpRequestHeader.Cookie, cookie);
            }

            return _wc;
        }
        [DataContract]
        internal class Member
        {
            [DataMember]
            public string id;
            [DataMember]
            public string name;
            [DataMember]
            public string signature;
            [DataMember]
            public string icon;
        }
        [DataContract]
        internal class MemberCollection
        {
            [DataMember]
            public List<Member> members;

            public MemberCollection()
            {
                members = new List<Member>();
            }

            public Member this[int i ]
            {
               get { return this.members[i]; }
            }
        }

        internal class UserInfo
        {
            internal bool isFirstTimeLogin;
            internal bool isLegalUser;
            internal MemberCollection memberInfo;

            internal bool parse(string rspData)
            {
                memberInfo = JsonHelper.JsonDeserialize<MemberCollection>(rspData);
                return (memberInfo != null);
            }
        }

        internal UserInfo login(string userName, string password)
        {
            Properties.Settings stg = new Properties.Settings();
            
            UserInfo ui = new UserInfo();
            // 1. login
            WebClient wc = getWebClient();
            string strParam = string.Format("account={0}&password={1}", userName, password);
            string trgUrl = stg.CloudServerUrl + "/login/authenticate.action";
            string rspData = wc.UploadString(trgUrl, strParam);

            // 2. select member
            bool bSucc = ui.parse(rspData);
            if (bSucc)
            {
                wc = getWebClient();
                wc.Headers.Add(HttpRequestHeader.Referer, trgUrl);
                trgUrl = stg.CloudServerUrl + "/login/selectMember.action?temp="+ getRandomString();
                strParam = string.Format("memberId={0}", ui.memberInfo[0].id);
                rspData = wc.UploadString(trgUrl,strParam);

                bSucc = isSelectMemberSuccess(rspData);
            }

            // 3. get user status
            if (bSucc)
            {
                wc = getWebClient();
                trgUrl = stg.CloudServerUrl + "/user/status.action";
                rspData = wc.UploadString(trgUrl, "");

                bSucc = isValidUserStatus(rspData);
            }

            return ui;
        }

        private bool isValidUserStatus(string rspData)
        {
            return true;
        }

        private bool isSelectMemberSuccess(string rspData)
        {
            return true;
        }

        internal string getRandomString()
        {
            Random rdm = new Random();
            double r = rdm.NextDouble();
            return r.ToString();
        }
    }
}
