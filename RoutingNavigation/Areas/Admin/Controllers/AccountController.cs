using Microsoft.AspNetCore.Mvc;
using RoutingNavigation.Areas.Admin.Models;

namespace RoutingNavigation.Areas.Admin.Controllers
{ 
    [Area("Admin")]
public class AccountController : Controller
    {
        
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(AdminLoginViewModel _alm)
        {
            if(ModelState.IsValid)
            {
                TempData["UserName"] = _alm.Username;
                return RedirectToAction("Dashboard", "Account"); 
            }   
            return View();
        }
        public IActionResult DashBoard()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }


    }
}
