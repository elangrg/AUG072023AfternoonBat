using Microsoft.AspNetCore.Mvc;

namespace AUG072023AfternoonBat.Controllers
{
    public class SortController : Controller
    {
        public string Index(string values, string id)
        {
            var brokenValues = values.Split('/');
            Array.Sort(brokenValues);
            return String.Join(", ", brokenValues);
        }
    }
}
