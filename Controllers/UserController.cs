using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

using OA_CRM.Models;
using EmitMapper;

namespace OA_CRM.Controllers
{
    public class UserController : Controller
    {
        OA_CRM.Models.MYCRMEntities etMgr = new Models.MYCRMEntities();
        //
        // GET: /User/
        public ActionResult Index()
        {
            var lst = etMgr.ADM_USER.ToList<ADM_USER>();
            return View(lst);
        }

        //
        // GET: /User/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /User/Create

        public ActionResult Add()
        {
            return View();
        } 

        //
        // POST: /User/Create

        [HttpPost]
        public ActionResult Add(ADM_USER model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.PASSWORD = Com.Mxm.EncryptionHelper.EncodeMD5(model.PASSWORD);
                    etMgr.AddToADM_USER(model);
                    if (etMgr.SaveChanges() != 0)
                    {

                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return RedirectToAction("Add");
                    }
                }
                else
                {
                    return RedirectToAction("Add");
                }
            }
            catch (Exception ex)
            {
                Com.Mxm.WriteTxt.WriteText(DateTime.Now.ToString() + "\t\n" + ex.Message + ex.StackTrace);
                return View();
            }
        }
        
        //
        // GET: /User/Edit/5
 
        public ActionResult Edit(int id)
        {
            ADM_USER user = etMgr.ADM_USER.Single(x => x.USER_ID == id);
            return View(user);
        }

        //
        // POST: /User/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, ADM_USER model)
        {
            try
            {
                var mo = etMgr.ADM_USER.FirstOrDefault(m => m.USER_ID == id);
                //TryUpdateModel(mo);
                //if (ModelState.IsValid)
                //{
                    if (etMgr.SaveChanges() != 0)
                    {
                        return RedirectToAction("Index");
                    }
                //}
            }
            catch (Exception ex)
            {
                Com.Mxm.WriteTxt.WriteText(DateTime.Now.ToString() + "\t\n" + ex.Message + ex.StackTrace);                
            }
            return View();
        }

        //
        // GET: /User/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /User/Delete/5

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

        public ActionResult ULogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ULogin(string username ,string password)
        {
            ADM_USER mo = etMgr.ADM_USER.FirstOrDefault(m => m.USERNAME == username);
            if (mo != null && mo.PASSWORD == Com.Mxm.EncryptionHelper.EncodeMD5(password))
            {
                FormsAuthentication.RedirectFromLoginPage(username, true);
                Response.Redirect("/"); 
            }
            else
            {
                var msg = "用户名或密码错误";
                ViewBag.msg = msg;
                //Response.Write("<script type='text/javascript'>alert('" + msg + "');</script>");
            }
            return View();
        }
    }
}
