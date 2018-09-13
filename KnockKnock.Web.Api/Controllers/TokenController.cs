using System;
using Microsoft.AspNetCore.Mvc;

namespace KnockKnock.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return Guid.Empty.ToString();
        }
    }
}