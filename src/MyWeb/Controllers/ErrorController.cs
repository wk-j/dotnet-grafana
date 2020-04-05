using System;
using Microsoft.AspNetCore.Mvc;

namespace MyWeb.Controllers {
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ErrorController : ControllerBase {

        [HttpGet]
        public IActionResult Raise() {
            throw new NullReferenceException();
        }
    }
}