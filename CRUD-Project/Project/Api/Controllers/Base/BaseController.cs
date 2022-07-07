using App.Shared.Commands;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers
{
    public abstract class BaseController : ControllerBase
    {
        protected ActionResult ApiResponse(Result result)
        {
            return StatusCode((int)result.StatusCode, result);
        }
    }
}