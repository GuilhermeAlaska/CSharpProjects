using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers
{
    [ApiController]
    [Route("v1/status")]
    public class HomeController : BaseController
    {
        [HttpGet]
        public IActionResult GetStatus()
        {
            return Ok();
        }
    }
}