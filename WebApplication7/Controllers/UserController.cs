using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
   
        public class UserController : Controller
        {
            public ActionResult Index()
            {
                ViewBag.Name = "Ruslan";
                ViewBag.Surname = "Murtuzaliyev";
                ViewBag.Age = 23;
                ViewBag.Country = "Azerbaijan";
                ViewBag.PhoneNumber = "+994504413450";

                return View();
            }
        }
    
}