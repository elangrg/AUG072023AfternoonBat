using Microsoft.AspNetCore.Mvc;

namespace AUG072023AfternoonBat.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToRoute("AnyName");



            //return View();
        }
    }
}
