using Microsoft.AspNetCore.Mvc;

namespace welfare.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       public IActionResult Tables()
      {
          return View();
        }
       public IActionResult Profile()
       {
           return View();
      }
      
        public IActionResult Register()
        {   
            return View();
        }
        public IActionResult Login()
        {   
            return View();
        }
    }

}
