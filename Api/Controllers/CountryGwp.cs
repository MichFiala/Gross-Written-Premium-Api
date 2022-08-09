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
		/// <summary>
		/// Gets average gross written premium
		/// </summary>
		/// <param name="arguments">Passed arguments</param>
		/// <remarks>
		/// Sample request:
		/// 
		///     POST server/api/gwp/avg
		///     {        
		///       "countryId": 1,
		///       "lineOfBusinessIds": [1, 2]
		///     }
		/// </remarks>
		/// <returns>All gross written premia for selected country and line of businesses</returns>
		/// <response code="200">Returns all average values found</response>
		/// <response code="400">If invalid parameter is passed</response>
		[HttpPost("avg")]
		public async Task<IActionResult> AverageGrossWrittenPremium([FromBody] AverageGrossWrittenPremiumArguments arguments)
		{
			try
			{
				return Ok(await grossWrittenPremiumService.GetAverageGrossPremium(arguments.CountryId, arguments.LineOfBusinessIds.ToArray()));
			}
			catch (Exception ex)
			{
				return BadRequest(ex.ToString());
			}
		}
		/// <summary>
		/// Gets all available countries
		/// </summary>
		/// <returns>All availabe countries</returns>
		/// <response code="200">Returns all availabe countries</response>
		/// <response code="400">If something wrong with database</response>
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
		/// <summary>
		/// Gets all available line of businesses
		/// </summary>
		/// <returns>All availabe line of businesses</returns>
		/// <response code="200">Returns all availabe line of businesses</response>
		/// <response code="400">If something wrong with database</response>
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

		public record AverageGrossWrittenPremiumArguments(int CountryId, int[] LineOfBusinessIds);
	}
}