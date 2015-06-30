using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using ComCode;
using Logging;

namespace YuexiuCloud
{
    public class UserMgr
    {
        WebClient _wc = null;
        string _cookie = null;

        public UserMgr()
        {

        }

        internal WebClient  getWebClient()
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

        [DataContract]
        internal class UserStatus
        {
            [DataMember]
            public string status;
            [DataMember]
            public string isAdmin;
            [DataMember]
            public string isProjectManager;
            [DataMember]
            public string addGroup;
            [DataMember]
            public string memberId;
            [DataMember]
            public string largeAttachId;
            [DataMember]
            public string personGroupId;
            [DataMember]
            public string memberName;
            [DataMember]
            public string name;
            [DataMember]
            public string account;
            [DataMember]
            public string memberIp;
        }

        public class UserInfo
        {
            internal string statusMsg;

            public bool isLegalUser
            {
                get
                {
                    if (userStatus != null)
                    {
                        return (userStatus.status == "login");
                    }
                    return false;
                }
            }

            internal MemberCollection memberInfo;
            internal Member currentMemberInfo;
            internal UserStatus userStatus;

            internal bool parseLoginResult(string rspData)
            {
                memberInfo = JsonHelper.JsonDeserialize<MemberCollection>(rspData);
                return (memberInfo != null);
            }

            internal bool parseStatusResult(string rspData)
            {
                userStatus = JsonHelper.JsonDeserialize<UserStatus>(rspData);
                return (userStatus != null);
            }

            internal bool parseSelMemberResult(string rspData)
            {
                currentMemberInfo = JsonHelper.JsonDeserialize<Member>(rspData);
                return (currentMemberInfo != null);
            }
        }

        internal LoginResult login(string userName, string password)
        {
            Properties.Settings stg = new Properties.Settings();
            LoginResult result = new LoginResult();
            UserInfo ui = new UserInfo();
            try
            {
                // 1. login
                WebClient wc = getWebClient();
                string strParam = string.Format("account={0}&password={1}", userName, password);
                string trgUrl = stg.CloudServerUrl + "/login/authenticate.action";
                string rspData = wc.UploadString(trgUrl, strParam);

                // 2. select member
                bool bSucc = ui.parseLoginResult(rspData);
                if (bSucc)
                {
                    wc = getWebClient();
                    wc.Headers.Add(HttpRequestHeader.Referer, trgUrl);
                    trgUrl = stg.CloudServerUrl + "/login/selectMember.action?temp=" + getRandomString();
                    strParam = string.Format("memberId={0}", ui.memberInfo[0].id);
                    rspData = wc.UploadString(trgUrl, strParam);

                    bSucc = ui.parseSelMemberResult(rspData);
                }

                // 3. get user status
                if (bSucc)
                {
                    wc = getWebClient();
                    trgUrl = stg.CloudServerUrl + "/user/status.action";
                    rspData = wc.UploadString(trgUrl, "");

                    bSucc = ui.parseStatusResult(rspData);
                }
            }
            catch(WebException ex)
            {
                result.code = "error";
                result.msg = "登录失败。原因：" + ex.Message;
                LogHelper.error(result.msg);
            }

            result.ui = ui;
            return result;
        }

        internal string getRandomString()
        {
            Random rdm = new Random();
            double r = rdm.NextDouble();
            return r.ToString();
        }
    }
}
