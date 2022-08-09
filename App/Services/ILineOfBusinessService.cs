using Domain;

namespace App.Services
{
	public interface ILineOfBusinessService
	{
		/// <summary>
		/// Should return Dto, no time to implement it
		/// </summary>
		/// <returns></returns>
		Task<List<LineOfBusiness>> Get();
	}
}