using Microsoft.AspNetCore.Mvc;

namespace AUG072023AfternoonBat.Controllers
{
    public class RazorViewEngineEgController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult SimpleLayoutContent()
        {
            return View();
        }
 public IActionResult NestedLayoutContent()
        {
            return View();
        }

    }
}
