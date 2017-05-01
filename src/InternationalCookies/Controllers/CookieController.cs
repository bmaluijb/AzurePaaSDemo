using Microsoft.AspNetCore.Mvc;
using InternationalCookies.Data.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace InternationalCookies.Controllers
{
    public class CookieController : Controller
    {
        private ICookieService _cookieService;

        public CookieController(ICookieService cookieService)
        {    
            _cookieService = cookieService;          
        }

        public IActionResult Index()
        {
            return View(_cookieService.GetAllCookies());
        }


        public IActionResult ClearCache()
        {
            _cookieService.ClearCache();

            return RedirectToAction("Index", "Home");
        }

    }
}
