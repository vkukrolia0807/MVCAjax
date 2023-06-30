using OrderManagement.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderManagement.Controllers
{
    public class GetDataController : Controller
    {
        // GET: GetData
        OrderManagementEntities db = new OrderManagementEntities();

        public JsonResult GetItemPrice(int itemId)
        {
            db.Configuration.ProxyCreationEnabled = false;
            Items item = db.Items.Find(itemId);
            return Json(item,JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetCouponDiscount(string couponCode)
        {
            db.Configuration.ProxyCreationEnabled = false;
            CouponCodeMaster coupons = db.CouponCodeMaster.Where(x=>x.couponCode.Equals(couponCode)).FirstOrDefault();
            if (coupons != null)
            {
                return Json(coupons, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("",JsonRequestBehavior.AllowGet);
            }
        }
    }
}