using Microsoft.AspNetCore.Mvc;

namespace AUG072023AfternoonBat.Controllers
{
    public class RazorViewEngineEgController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
