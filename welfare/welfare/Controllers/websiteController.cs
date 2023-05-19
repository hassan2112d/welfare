using Microsoft.AspNetCore.Mvc;
using welfare.Data;
using welfare.Models;

namespace welfare.Controllers
{
    public class websiteController : Controller
    {
        Dbcontext1 db_context;
        public websiteController(Dbcontext1 dbcontext)
        {
            this.db_context = dbcontext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Donate()
        {
            return View();
        }

        public IActionResult Causes()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(contact r)
        {
            db_context.contacts.Add(r);
            db_context.SaveChanges();
            ModelState.Clear();
            return View();
        }
        public IActionResult Event()
        {
            return View();
        }
        public IActionResult Gallery()
        {
            return View();
        }

        public IActionResult abc()
        {
            return View();
        }
    }
}
