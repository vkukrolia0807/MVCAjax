using OrderManagement.Models.Models;
using OrderManagement.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderManagement.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        private IUser LoginInterface;
        public LoginController()
        {

        }
        public LoginController(IUser iUser)
        {
            LoginInterface = iUser;
        }
        [HttpGet]
        public ActionResult Login()
        {
            try
            {
                return View();
            }
            catch (Exception e)
            {
                ViewBag.error = e.Message;
                return View("Error");
            }
        }
        [HttpPost]
        public ActionResult Login(UserModel user)
        {
            try
            {
                string result = LoginInterface.Login(user);
                if (result != "Invalid Email" && result != "Invalid Password")
                {
                    Session["id"]= result;
                    return RedirectToAction("AddOrder","Order");
                }
                ViewBag.error = result;
                return View();
            }
            catch (Exception e)
            {
                ViewBag.error = e.Message;
                return View("Error");
            }
        }
        public ActionResult Logout()
        {
            try
            {
                Session.Abandon();
                return RedirectToAction("Login");
            }
            catch (Exception e)
            {
                ViewBag.error = e.Message;
                return View("Error");
            }
        }
    }
}