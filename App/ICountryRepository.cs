using Domain;

namespace App
{
	public interface ICountryRepository
	{
		Task<List<Country>> Get();

		Task<Country?> Get(int id);
	}
}