using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using OA_CRM.Models;

namespace OA_CRM.ajax
{
    /// <summary>
    /// 获取菜单列表
    /// </summary>
    public class GetMenu : IHttpHandler
    {
        MYCRMEntities etMgr = new MYCRMEntities();
        public void ProcessRequest(HttpContext context)
        {
            string reVal = string.Empty;
            try
            {
                context.Response.ContentType = "text/plain";
                IEnumerable<MENU> list = from m in etMgr.MENU.OfType<MENU>()
                                         where m.PARENT_ID == 0
                                         select m;
                StringBuilder sb = new StringBuilder();
                StringWriter sw = new StringWriter(sb);
                using (JsonWriter jsonWriter = new JsonTextWriter(sw))
                {
                    jsonWriter.Formatting = Formatting.Indented;
                    jsonWriter.WriteStartArray();
                    foreach (MENU m in list)
                    {
                        jsonWriter.WriteStartObject();
                        jsonWriter.WritePropertyName("name");
                        jsonWriter.WriteValue(m.NAME);
                        jsonWriter.WritePropertyName("id");
                        jsonWriter.WriteValue(m.MENU_ID);
                        jsonWriter.WritePropertyName("url");
                        jsonWriter.WriteValue(m.URL);
                        jsonWriter.WritePropertyName("target");
                        jsonWriter.WriteValue(string.IsNullOrEmpty(m.TARGET.Trim()) ? "_parent" : m.TARGET);
                        if (etMgr.MENU.Count(me => me.PARENT_ID == m.MENU_ID) > 0)
                        {
                            jsonWriter.WritePropertyName("nodes");
                            sb.Append(GetChildStr(m.MENU_ID));
                        }
                        jsonWriter.WriteEndObject();
                    }
                    jsonWriter.WriteEnd();
                }
                reVal = sb.ToString();
            }
            catch (Exception ex)
            {
                Com.Mxm.WriteTxt.WriteText(ex.Message);
            }
            finally
            {
                etMgr.Dispose();
            }
            context.Response.Write(reVal);
        }

        private string GetChildStr(int parent_id)
        {
            string reVal = string.Empty;
            if (parent_id > 0)
            {
                IEnumerable<MENU> list = from m in etMgr.MENU.OfType<MENU>()
                                         where m.PARENT_ID==parent_id
                                         select m;
                StringBuilder sb = new StringBuilder();
                StringWriter sw = new StringWriter(sb);
                using (JsonWriter jsonWriter = new JsonTextWriter(sw))
                {
                    jsonWriter.Formatting = Formatting.Indented;
                    jsonWriter.WriteStartArray();
                    foreach (MENU m in list)
                    {
                        jsonWriter.WriteStartObject();
                        jsonWriter.WritePropertyName("name");
                        jsonWriter.WriteValue(m.NAME);
                        jsonWriter.WritePropertyName("id");
                        jsonWriter.WriteValue(m.MENU_ID);
                        jsonWriter.WritePropertyName("url");
                        jsonWriter.WriteValue(m.URL);
                        jsonWriter.WritePropertyName("target");
                        jsonWriter.WriteValue(string.IsNullOrEmpty(m.TARGET.Trim()) ? "_parent" : m.TARGET);
                        if (etMgr.MENU.Count(me => me.PARENT_ID == m.MENU_ID) > 0)
                        {
                            jsonWriter.WritePropertyName("nodes");
                            sb.Append(GetChildStr(m.MENU_ID));
                        }
                        jsonWriter.WriteEndObject();
                    }
                    jsonWriter.WriteEnd();
                }
                reVal = sb.ToString();
            }
            return reVal;
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}