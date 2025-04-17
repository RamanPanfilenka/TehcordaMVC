using Microsoft.AspNetCore.Mvc;
using Tehcorda.MVC.Models;

namespace Tehcorda.MVC.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            var loginModel = new LoginModel();
            return View(loginModel);
        }

        [HttpPost]
        public IActionResult Login(LoginModel loginModel)
        {
            if (ModelState.IsValid) 
            {
                return RedirectToActionPermanent("Index", "Home");
            }

            return View(loginModel);
        }

        public IActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        public IActionResult IndexP() 
        {
            return RedirectToActionPermanent("Index", "Home");
        }

        public IActionResult Register()
        {
            return View("~/Views/Home/Register");

            //return RedirectToAction("Index", "Home");
        }
    }
}
