using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers
{
    [ApiController]
    [Route("v1/users")]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
