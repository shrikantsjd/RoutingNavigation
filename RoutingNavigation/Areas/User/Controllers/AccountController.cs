using Microsoft.AspNetCore.Mvc;
using RoutingNavigation.Areas.User.Models;

namespace RoutingNavigation.Areas.User.Controllers
{ 
    [Area("User")]
public class AccountController : Controller
    {
        
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserLoginViewModel _alm)
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
