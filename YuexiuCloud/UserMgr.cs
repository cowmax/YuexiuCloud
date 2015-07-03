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
        public UserInfo ui = new UserInfo();
        /// <summary>
        /// Current user name
        /// </summary>
        public string UserName
        {
            get
            {
                return ui.currentMemberInfo.name;
            }
        }

        public UserMgr()
        {

        }

        [DataContract]
        public class Member
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
        public class MemberCollection
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
        public class UserStatus
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

        public LoginResult login(string userName, string password)
        {
            Properties.Settings stg = new Properties.Settings();
            LoginResult result = new LoginResult();

            try
            {
                // 1. login
                WebClient wc = Program.getWebClient();
                string strParam = string.Format("account={0}&password={1}", userName, password);
                string trgUrl = stg.CloudServerUrl + "/login/authenticate.action";
                string rspData = wc.UploadString(trgUrl, strParam);

                // 2. select member
                bool bSucc = ui.parseLoginResult(rspData);
                if (bSucc)
                {
                    wc = Program.getWebClient();
                    wc.Headers.Add(HttpRequestHeader.Referer, trgUrl);
                    trgUrl = stg.CloudServerUrl + "/login/selectMember.action?temp=" + getRandomString();
                    strParam = string.Format("memberId={0}", ui.memberInfo[0].id);
                    rspData = wc.UploadString(trgUrl, strParam);

                    bSucc = ui.parseSelMemberResult(rspData);
                }

                // 3. get user status
                if (bSucc)
                {
                    wc = Program.getWebClient();
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
