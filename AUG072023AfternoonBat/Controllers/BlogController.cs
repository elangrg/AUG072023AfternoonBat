using Microsoft.AspNetCore.Mvc;

namespace AUG072023AfternoonBat.Controllers
{
    public class BlogController : Controller
    {
        public string Archive(DateTime? entryDate)
        {
            return entryDate.ToString();




        }
    }
}
