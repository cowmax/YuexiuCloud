using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComCode;

namespace YuexiuCloud
{
    public class SettingItem
    {
        public string name;
        public object val;
        public Type typ;
        public int status;
        public DateTime update;

        public SettingItem(string name, object val, Type typ, int status, DateTime update)
        {
            this.name = name;
            this.val = val;
            this.typ = typ;
            this.status = status;
            this.update = update;
        }
    }

    public class SettingCollection
    {
        protected List<SettingItem> _items = null;
        protected string settingFilePath = null;

    }

    public class YuexiuSettings : SettingCollection
    {
        public YuexiuSettings()
        {
              
        }
        // Load app setting from specified file
        public bool load(string filePath)
        {
            bool bSucc = true;
            try
            {
                FileStream fs = new FileStream(base.settingFilePath, FileMode.OpenOrCreate, FileAccess.Write);
                TextReader txtReader = new StreamReader(fs);
                string stgStr = txtReader.ReadToEnd();
                base._items = JsonHelper.JsonDeserialize <List<SettingItem>> (stgStr);
                base.settingFilePath = filePath;
            }
            catch(IOException ex)
            {

            }

            return bSucc;
        }

        public bool save()
        {
            if (base.settingFilePath == null) return false;

            bool bSucc = true;
            try
            {
                FileStream fs = new FileStream(base.settingFilePath, FileMode.OpenOrCreate|FileMode.Truncate, FileAccess.ReadWrite);
                TextWriter txtWriter = new StreamWriter(fs);
                if (base._items.Count == 0)
                {
                    throw new NotImplementedException("Hello !");
                }
                string stgStr = JsonHelper.JsonSerializer(base._items);
                txtWriter.Write(stgStr.ToCharArray());
                txtWriter.Close();
                fs.Close();
            }
            catch(IOException ex)
            {

            }


            return bSucc;
        }

        private string getCurrentUser()
        {
            throw new NotImplementedException();
        }
    }

    public class SettingMgr
    {
    }
}
