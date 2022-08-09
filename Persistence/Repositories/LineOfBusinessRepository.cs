using App;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
	public class LineOfBusinessRepository : ILineOfBusinessRepository
	{
		private readonly DataContext context;

		public LineOfBusinessRepository(DataContext context)
		{
			this.context = context;
		}
		public Task<List<LineOfBusiness>> Get() => context.LineOfBusinesses.ToListAsync();

		public Task<List<LineOfBusiness>> Get(int[] ids) => context.LineOfBusinesses.Where(x => ids.Contains(x.Id)).ToListAsync();
	}
}