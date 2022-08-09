using App.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
	[ApiController]
	[Route("server/api/gwp")]
	public class CountryGwp : ControllerBase
	{
		private readonly ICountryService countryService;
		private readonly IGrossWrittenPremiumService grossWrittenPremiumService;
		private readonly ILineOfBusinessService lineOfBusinessService;

		public CountryGwp(
		  ICountryService countryService,
		  IGrossWrittenPremiumService grossWrittenPremiumService,
		  ILineOfBusinessService lineOfBusinessService)
		{
			this.countryService = countryService;
			this.grossWrittenPremiumService = grossWrittenPremiumService;
			this.lineOfBusinessService = lineOfBusinessService;
		}
		[HttpPost("avg")]
		public async Task<IActionResult> AvarageGrossWrittenPremium(int countryId, List<int> lineOfBusinessIds)
		{
			try
			{
				return Ok(await grossWrittenPremiumService.GetAverageGrossPremium(countryId, lineOfBusinessIds.ToArray()));
			}
			catch (Exception ex)
			{
				return BadRequest(ex.ToString());
			}
		}
		[HttpGet("countries")]
		[ResponseCache(Duration = 10, Location = ResponseCacheLocation.Any, NoStore = false)]
		public async Task<IActionResult> GetCountries()
		{
			try
			{
				return Ok(await countryService.Get());
			}
			catch (Exception ex)
			{
				return BadRequest(ex.ToString());
			}
		}
		[HttpGet("lineofbusinesses")]
		[ResponseCache(Duration = 10, Location = ResponseCacheLocation.Any, NoStore = false)]
		public async Task<IActionResult> GetLineOfBusinesses()
		{
			try
			{
				return Ok(await lineOfBusinessService.Get());
			}
			catch (Exception ex)
			{
				return BadRequest(ex.ToString());
			}
		}
	}
}