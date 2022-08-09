using Domain;

namespace App.Services
{
	public class CountryService : ICountryService
	{
		private readonly ICountryRepository repository;

		public CountryService(ICountryRepository repository)
        {
			this.repository = repository;
		}
		public Task<List<Country>> Get() => repository.Get();
	}
}