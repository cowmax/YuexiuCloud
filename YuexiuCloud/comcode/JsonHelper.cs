using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web.Script.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace ComCode
{
    public class JsonHelper
    {
        // Convert DataTable to JSON string
        public static string DataTableToJson(DataTable dt)
        {
            string columnFirst = "";
            List<string> result = new List<string>();
            StringBuilder Json = new StringBuilder();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (columnFirst != dt.Rows[i][0].ToString())
                    {
                        if (i != 0)
                        {
                            addNewJsonRow(Json, result, dt);
                        }
                        columnFirst = dt.Rows[i][0].ToString();
                        result = new List<string>();
                        for (int k = 0; k < dt.Columns.Count; k++)
                        {
                            result.Add("\"" + dt.Rows[i][k].ToString() + "\"");
                        }
                    }
                    else
                    {
                        for (int k = 0; k < dt.Columns.Count; k++)
                        {
                            if (!result[k].Contains(dt.Rows[i][k].ToString()))
                            {
                                result[k] += ",\"" + dt.Rows[i][k].ToString() + "\"";
                            }
                        }
                    }
                    if (i == dt.Rows.Count - 1)
                    {
                        addNewJsonRow(Json, result, dt);
                    }
                }
            }
            return Json.ToString();
        }

        /// <summary>
        /// Add data-row to with JSON format
        /// </summary>
        /// <param name="json"></param>
        /// <param name="result">values of one row in datable</param>
        /// <param name="dtUsers">DataTable object provides Column Collection for key name of JSON string.</param>
        private static void addNewJsonRow(StringBuilder Json, List<string> result, DataTable dt)
        {
            Json.Append("{");
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                Json.Append("\"");
                Json.Append(dt.Columns[i].ColumnName);
                Json.Append("\":");
                if (result[i].Contains(","))
                {
                    Json.Append("[");
                    Json.Append(result[i]);
                    if (i == dt.Columns.Count - 1)
                    {
                        Json.Append("]");
                    }
                    else
                    {
                        Json.Append("],");
                    }
                }
                else
                {
                    Json.Append(result[i]);
                    if (i != dt.Columns.Count - 1)
                    {
                        Json.Append(",");
                    }
                }
            }
            Json.Append("}");
        }

        // Convert given JSON string to Dictionary object
        public static Dictionary<string, string> JsonStrToDict(string jsonString)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Dictionary<string, string>));
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
            Dictionary<string, string> jsonObject = (Dictionary<string, string>)ser.ReadObject(ms);
            return jsonObject;
        }

        public static Dictionary<string, string> JsonToDict(string jsonString)
        {
            //实例化JavaScriptSerializer类的新实例
            JavaScriptSerializer jss = new JavaScriptSerializer();
            try
            {
                //将指定的 JSON 字符串转换为 Dictionary<string, object> 类型的对象
                return jss.Deserialize<Dictionary<string, string>>(jsonString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Dictionary<string, object> JsonToDictionary(string jsonString)
        {
            //实例化JavaScriptSerializer类的新实例
            JavaScriptSerializer jss = new JavaScriptSerializer();
            try
            {
                //将指定的 JSON 字符串转换为 Dictionary<string, object> 类型的对象
                return jss.Deserialize<Dictionary<string, object>>(jsonString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        // Convert dictionary object to JSON string
        public static string DictionaryToJson(Dictionary<int, List<int>> dict)
        {
            var entries = dict.Select(d => string.Format("\"{0}\": [{1}]", d.Key, string.Join(",", d.Value)));
            return "{" + string.Join(",", entries) + "}";
        }

        /// <summary>
        /// JSON序列化
        /// </summary>
        public static string JsonSerializer<T>(T t)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
            MemoryStream ms = new MemoryStream();
            ser.WriteObject(ms, t);
            string jsonString = Encoding.UTF8.GetString(ms.ToArray());
            ms.Close();
            return jsonString;
        }
        /// <summary>
        /// JSON反序列化
        /// </summary>
        public static T JsonDeserialize<T>(string jsonString)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
            T obj = (T)ser.ReadObject(ms);
            return obj;
        }
    }
}