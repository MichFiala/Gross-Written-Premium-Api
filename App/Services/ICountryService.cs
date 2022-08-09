using Domain;

namespace App.Services
{
	public interface ICountryService
	{
		/// <summary>
		/// Should return Dto, no time to implement it
		/// </summary>
		/// <returns></returns>
		Task<List<Country>> Get();
	}
}