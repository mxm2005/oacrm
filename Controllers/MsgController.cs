using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OA_CRM.Models;

namespace OA_CRM.Controllers
{
    public class MsgController : Controller
    {
        OA_CRM.Models.MYCRMEntities etMgr = new Models.MYCRMEntities();
        //
        // GET: /Msg/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Msg/Details/5

        public ActionResult Detail(int? id)
        {
            return View();
        }

        //
        // GET: /Msg/Create

        public ActionResult Add()
        {
            return View();
        } 

        //
        // POST: /Msg/Create

        [HttpPost]
        public ActionResult Add(MESSAGE_HISTORY model)
        {
            try
            {
                // 增加数据
                if (ModelState.IsValid)
                {
                    //etMgr.AddToMESSAGE_HISTORY(msg);
                    if (etMgr.SaveChanges() != 0)
                    {

                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return RedirectToAction("Add");
                    }
                }
                return RedirectToAction("Add");
            }
            catch (Exception ex)
            {
                Com.Mxm.WriteTxt.WriteText(ex.Message + ex.StackTrace);
                return View();
            }
        }
                
        //
        // POST: /Msg/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        /// <summary>
        /// 发件箱
        /// </summary>
        /// <returns></returns>
        public ActionResult SendBox()
        {
            return View();
        }

        /// <summary>
        /// 系统通知
        /// </summary>
        /// <returns></returns>
        public ActionResult System()
        {
            return View();
        }
    }
}
