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

public IActionResult HTMLHelperVsTagHelper()
        {
            return View();
        }

public IActionResult TagHelperEg()
        {
            return View();
        }

public string TagHelperEgWithID(int id)
        {
            return "Value in ID" + id;
        }

        [Route("/demo/abc", Name = "nmdRoute")]
        public string SomeActMethod() { return "Hello"; }

        public string anotherActMethod(string EmpName, int EmpID)
        {
            return $"Enm={EmpName} -- eID={EmpID}";
        }




    }
}
