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
    /// Summary description for GetUsers
    /// </summary>
    public class GetUsers : IHttpHandler
    {
        MYCRMEntities etMgr = new MYCRMEntities();
        public void ProcessRequest(HttpContext context)
        {
            string reVal = string.Empty;
            context.Response.ContentType = "text/plain";
            IEnumerable<ADM_USER> list = from m in etMgr.ADM_USER.OfType<ADM_USER>()
                                         select m;
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            using (JsonWriter jsonWriter = new JsonTextWriter(sw))
            {
                jsonWriter.Formatting = Formatting.Indented;
                jsonWriter.WriteStartArray();
                foreach (ADM_USER m in list)
                {
                    jsonWriter.WriteStartObject();
                    jsonWriter.WritePropertyName("name");
                    jsonWriter.WriteValue(string.IsNullOrEmpty(m.REAL_NAME) ? m.USERNAME : m.REAL_NAME);
                    jsonWriter.WritePropertyName("id");
                    jsonWriter.WriteValue(m.USER_ID);
                    jsonWriter.WriteEndObject();
                }
                jsonWriter.WriteEnd();
            }
            reVal = sb.ToString();
            context.Response.Write(reVal);
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