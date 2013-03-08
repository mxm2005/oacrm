using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OA_CRM.Models;

namespace OA_CRM.Controllers
{
    public class CusController : Controller
    {
        OA_CRM.Models.MYCRMEntities etMgr = new Models.MYCRMEntities();
        // GET: /CusList/
        public ActionResult CusList()
        {
            var lst = etMgr.CUSTOMER.ToList<CUSTOMER>();
            return View(lst);
        }

        //
        // GET: /Cus/Details/5

        public ActionResult Details(int id)
        {
            var obj = etMgr.CUSTOMER.Single<CUSTOMER>(o => o.CUSTOMER_ID == id);
            return View(obj);
        }

        //
        // GET: /Cus/Add

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult test()
        {
            return View();
        } 

        //
        // POST: /Cus/Create

        [HttpPost]
        public ActionResult Add(CUSTOMER model)
        {            
            try
            {
                if (ModelState.IsValid)
                {
                    etMgr.AddToCUSTOMER(model);
                    if (etMgr.SaveChanges() != 0)
                    {

                        return RedirectToAction("CusList");
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
        // GET: /Cus/Edit/5
 
        public ActionResult Edit(int id)
        {
            CUSTOMER customer = etMgr.CUSTOMER.FirstOrDefault(x => x.CUSTOMER_ID == id);
            return View(customer);
        }

        //
        // POST: /Cus/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, CUSTOMER model)
        {
            try
            {
                CUSTOMER customer = etMgr.CUSTOMER.FirstOrDefault(x => x.CUSTOMER_ID == id);
                customer.CUSTOMER_NAME = model.CUSTOMER_NAME;
                customer.TEL = model.TEL;
                customer.REMARK = model.REMARK;
                customer.ADDRESS = model.ADDRESS;
                customer.CORPERATION = model.CORPERATION;
                customer.CREATE_TIME = DateTime.Now;
                customer.CUSTOM_TYPE = 0;
                customer.EMAIL = model.EMAIL;
                customer.FAX = model.FAX;
                customer.LINKMAN = model.LINKMAN;
                customer.MOBILE = model.MOBILE;
                customer.POSTCODE = model.POSTCODE;
                customer.QQ = model.QQ;
                customer.SERVICE_USER = model.SERVICE_USER;
                customer.SEX = model.SEX;
                customer.UPDATE_TIME = DateTime.Now;
                customer.USER_STATE = 1;
                customer.USER_FROM = 1;
                customer.WEBURL = model.WEBURL;

                int reVal= etMgr.SaveChanges();
                if (reVal > 0)
                {
                    return RedirectToAction("CusList");
                }
                else
                {
                    return RedirectToAction("Edit");
                }
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Cus/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Cus/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("CusList");
            }
            catch
            {
                return View();
            }
        }
    }
}
