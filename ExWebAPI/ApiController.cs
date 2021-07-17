using Microsoft.AspNetCore.Mvc;

namespace ExWebAPI
{
    [ApiController]
    [Route("api")]
    public class ApiController : Controller
    {
        private static readonly string[] Regions =
        {
            "Europe",
            "Asia",
            "North America",
            "South America",
            "Africa",
            "Australia"
        };
        
        [HttpGet]
        [Route("regions")]
        public IActionResult GetRegions()
        {
            return Ok(Regions);
        }
    }
}