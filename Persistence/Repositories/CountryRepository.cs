using App;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
	public class CountryRepository : ICountryRepository
	{
		private readonly DataContext context;

		public CountryRepository(DataContext context)
        {
			this.context = context;
		}
		public Task<List<Country>> Get() => context.Countries.ToListAsync();

		public Task<Country?> Get(int id) => context.Countries.SingleOrDefaultAsync(x => x.Id == id);
	}
}