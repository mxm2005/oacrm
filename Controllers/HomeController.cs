using System;
using System.Data.Objects;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using OA_CRM.Models;

namespace OA_CRM.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        MYCRMEntities etMgr;
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult left()
        {
            ViewBag.users = GetUsers();
            return View();
        }
        public ActionResult right()
        {
            return View();
        }
        public ActionResult right_tool()
        {
            return View();
        }
        public ActionResult admin_top()
        {
            return View();
        }
        public ActionResult admintitle()
        {
            return View();
        }
        public ActionResult login()
        {
            return View();
        }

        private string GetUsers()
        {
            IList<MENU> list;            
            using (etMgr = new MYCRMEntities())
            {
                var lst = from m in etMgr.MENU.OfType<MENU>()
                       where m.PARENT_ID == 0 && m.STATUS==1                       
                       select m;
                list = lst.ToList<MENU>();
            }
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
                    int count = 0;
                    using (etMgr = new MYCRMEntities())
                    {
                        count = etMgr.MENU.Count(me => me.PARENT_ID == m.MENU_ID && me.STATUS==1);
                    }
                    if (count> 0)
                    {
                        jsonWriter.WritePropertyName("nodes");
                        sb.Append(GetChildStr(m.MENU_ID));
                    }
                    jsonWriter.WriteEndObject();
                }
                jsonWriter.WriteEnd();
            }
            return sb.ToString();
        }

        private string GetChildStr(int parent_id)
        {
            string reVal = string.Empty;
            if (parent_id > 0)
            {
                IList<MENU> list;
                using (etMgr = new MYCRMEntities())
                {
                    var lst = from m in etMgr.MENU.OfType<MENU>()
                           where m.PARENT_ID == parent_id && m.STATUS==1
                           select m;
                    list = lst.ToList<MENU>();
                }                
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
                        int count = 0;
                        using (etMgr = new MYCRMEntities())
                        {
                            count = etMgr.MENU.Count(me => me.PARENT_ID == m.MENU_ID && me.STATUS==1);
                        }
                        if (count > 0)
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
    }
}
