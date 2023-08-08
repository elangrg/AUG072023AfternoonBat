using Microsoft.AspNetCore.Mvc;

namespace AUG072023AfternoonBat.Controllers
{
    public class DependencyInjectEgController : Controller
    {
        Models.Employee _employee;
        public DependencyInjectEgController(Models.Employee employee )
        {
            _employee = employee;
        }


        public IActionResult Index([FromServices] Models.Employee LocalEmp)
        {

            ViewBag.LocalEmp = LocalEmp.GetHashCode();
            ViewBag.employee=_employee.GetHashCode(); 


            return View();
        }
    }
}
