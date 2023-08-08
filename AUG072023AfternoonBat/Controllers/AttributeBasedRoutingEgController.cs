using Microsoft.AspNetCore.Mvc;

namespace AUG072023AfternoonBat.Controllers
{
    [Route("ABRDemo")]
    public class AttributeBasedRoutingEgController : Controller
    {
        // [Route("Defaultpage")]
        //[Route("")] // combine
       // [Route("abc")]
        //[Route("xyz/Index")]
        //[HttpGet("[controller]/[action]")]
        // [Route("/")] //  Doesn't combine,
        public string Index(int id)
        {
            return "In Index page";
        }

        [Route("/Home/About")]
        public string About()
        {
            return "About called";
        }
        [Route("Home/Contact")]
        public string Contact()
        {
            return "<h1> Contact Page </h1>";
        }

        [HttpGet("/products")]
        public string HttpGetProducts()
        {
            return "HttpGetProducts called";
        }

        [HttpGet("/products/{id:int}", Name = "AnyName")] // Route Name 
        public string HttpGetWithIDMust(int id)
        {
            return $"HttpGetWithIDMust  {id}";
        }


        [HttpPost("/products/{somedata:alphanumeric}")]
        public string CreateProduct(string somedata)
        {
            return "CreateProduct";
        }
    }
}
