using App;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
	public class GrossWrittenPremiumRepository : IGrossWrittenPremiumRepository
	{
        private readonly DataContext context;

		public GrossWrittenPremiumRepository(DataContext context)
        {
			this.context = context;
		}
		public Task<List<GrossWrittenPremium>> Get() => context.GrossWrittenPremia.ToListAsync();

		public Task<List<GrossWrittenPremium>> Get(int countryId, int[] lineOfBusinesses, DateTime from, DateTime to) => 
			context.GrossWrittenPremia
				.Where(x => 
						x.CountryId == countryId && 
						lineOfBusinesses.Contains(x.LineOfBusinessId) &&
						// Filter from
						x.DateTime.Year >= from.Year && 
						x.DateTime.Month >= from.Month && 
						x.DateTime.Day >= from.Day &&
						// Filter to
						x.DateTime.Year <= to.Year && 
						x.DateTime.Month <= to.Month && 
						x.DateTime.Day <= to.Day
					).ToListAsync();
	}
}