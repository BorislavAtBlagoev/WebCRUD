using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Catstagram.Features
{
    public class HomeController : ApiController
    {
        [Authorize]
        [HttpGet]
        public ActionResult Get()
        {
            return this.Ok("TEST");
        }
    }
}
