using OrderManagement.Helpers.Helpers;
using OrderManagement.Models.Context;
using OrderManagement.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderManagement.Controllers
{
    [LoginFilter]
    public class OrderController : Controller
    {
        // GET: Order
        OrderManagementEntities db = new OrderManagementEntities();
        public ActionResult AddOrder()
        {
            try
            {
                OrderModel order = new OrderModel();
                int userId;
                if (Session["id"] == null)
                {
                    userId = db.Users.Where(x => x.email.Equals("vikrant@gmail.com")).FirstOrDefault().id;
                }
                else
                {
                    //userId = (int)Session["id"];
                    userId = Convert.ToInt32(Session["id"]) + 0;
                }
                order.userId = userId;
                order.itemList= db.Items.ToList();
                return View(order);
            }
            catch (Exception e)
            {
                ViewBag.error = e.Message;
                return View("Error");
            }
        }
        [HttpPost]
        public ActionResult AddOrder(OrderModel order)
        {
            try
            {
                if (order.couponCode!=null)
                {
                    int couponCode = db.CouponCodeMaster.Where(x => x.couponCode.Equals(order.couponCode)).FirstOrDefault().couponId;
                    CouponCodeMaster decreaseCoupon = db.CouponCodeMaster.Where(x => x.couponId == couponCode).FirstOrDefault();
                    decreaseCoupon.couponUsageLimit = decreaseCoupon.couponUsageLimit - 1;
                    orders orderDb = OrderHelper.ModelToDb(order,couponCode);
                    db.orders.Add(orderDb);
                    db.SaveChanges();
                    TempData["success"] = "Order Added Successsfully";
                }
                else
                {
                    orders orderDb = OrderHelper.ModelToDb(order, 0);
                    db.orders.Add(orderDb);
                    db.SaveChanges();
                    TempData["success"] = "Order Added Successsfully";
                }
                return RedirectToAction("OrderList");
            }
            catch (Exception e)
            {
                ViewBag.error = e.Message;
                return View("Error");
            }
        }
        public ActionResult OrderList()
        {
            try
            {
                int userId;
                if (Session["id"] == null)
                {
                    userId = db.Users.Where(x => x.email.Equals("vikrant@gmail.com")).FirstOrDefault().id;
                }
                else
                {
                    userId = Convert.ToInt32(Session["id"]) + 0;
                }
                List<orders> orderList = db.orders.Where(x => x.userId == userId).ToList();
                return View(orderList);
            }
            catch (Exception e)
            {

                ViewBag.error = e.Message;
                return View("Error");
            }
        }
    }
}
