using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
	[ApiController]
    [Route("server/api/gwp")]
    public class CountryGwp : ControllerBase
    {
        [HttpPost("avg")]
        public IActionResult AvarageGrossWrittenPremium(){
			return Ok("Ok");
		}
    }
}