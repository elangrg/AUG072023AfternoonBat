using Microsoft.AspNetCore.Mvc;

namespace AUG072023AfternoonBat.Controllers
{
    public class ValidationEgController : Controller
    {
        public IActionResult AddNewProject()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewProject(Models.Project project)
        {

            if (project.ProjectName.Length < 5)
            {
                ModelState.AddModelError("ProjectName", "Project Min Length must be 4");

            }


            if (ModelState.IsValid)
            {


            }




            return View();
        }



        [AcceptVerbs("Get", "Post")]
        public IActionResult ProjectNameTaken(string ProjectName)
        {
            if (ProjectName == "DEMO")
            {
                return Json($"Project Name {ProjectName} is already Taken.");
            }

            return Json(true);
        }


    }
}
