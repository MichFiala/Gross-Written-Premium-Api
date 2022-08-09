using Domain;

namespace App.Services
{
	public class LineOfBusinessService : ILineOfBusinessService
	{
		private readonly ILineOfBusinessRepository repository;

		public LineOfBusinessService(ILineOfBusinessRepository repository)
        {
			this.repository = repository;
		}
		public Task<List<LineOfBusiness>> Get() => repository.Get();
	}
}