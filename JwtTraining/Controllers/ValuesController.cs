using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtTraining.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Authorize] // The Bearer toekn has to be passed when requesting this particular endpoint
        //if it is correct, the user will be authorized to access this endpoint and return the following string value
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult Get()
        {
            return Ok(new {value="This is a protected value"});
        }
    }
}
