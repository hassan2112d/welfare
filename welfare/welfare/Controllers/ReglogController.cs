using Microsoft.AspNetCore.Mvc;
using System;
using welfare.Data;
using welfare.Models;

namespace welfare.Controllers
{
 
    public class ReglogController : Controller
    {
        Dbcontext1 db_context;
        public ReglogController(Dbcontext1 dbcontext)
        {
            this.db_context = dbcontext;
        }

        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult Registration()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult Registration(RegisterModel r)
        {
            db_context.registrations.Add(r);
            db_context.SaveChanges();
            ModelState.Clear();
            ViewBag.success = "Admin Registered!";
            return View("Login");
        }


        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(RegisterModel reg)
        {
            var myvalue = db_context.registrations.Where(a => a.Email == reg.Email
            && a.Password == reg.Password).FirstOrDefault();
            if (myvalue != null)
            {
                HttpContext.Session.SetString("myUsername", myvalue.Name);
                var name = HttpContext.Session.GetString("myUsername");
                ViewBag.currentUsername = name;
            
                return RedirectToAction("Dashboard");
            }
            ModelState.Clear();
            ViewBag.error = "Data not found!";
            return View();
        }
    }
    }
