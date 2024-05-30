using Microsoft.AspNetCore.Mvc;

namespace ViewTempAndSession.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {   
            ViewBag.VAR = "tHIS IS View Bag";
            ViewData["var2"] = "This is View DATA";
            TempData["var3"] = "This is Temp Data";
            HttpContext.Session.SetString("Var4", "This is Session Data");
            return RedirectToAction("About");
        }
        public IActionResult About()
        {
           
            return View();
        }
    }
}
