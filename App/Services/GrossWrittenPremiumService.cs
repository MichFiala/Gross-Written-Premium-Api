using App.Models;

namespace App.Services
{
	public class GrossWrittenPremiumService : IGrossWrittenPremiumService
	{
		private readonly IGrossWrittenPremiumRepository repository;
		private readonly ICountryRepository countryRepository;
		private readonly ILineOfBusinessRepository lineOfBusinessRepository;

		public GrossWrittenPremiumService(
            IGrossWrittenPremiumRepository repository,
            ICountryRepository countryRepository, 
            ILineOfBusinessRepository lineOfBusinessRepository)
        {
			this.repository = repository;
			this.countryRepository = countryRepository;
			this.lineOfBusinessRepository = lineOfBusinessRepository;
		}
		public async Task<List<AverageGrossWrittenPremiumDto>> GetAverageGrossPremium(int countryId, int[] lineOfBusinessIds)
		{
            if(lineOfBusinessIds.Length == 0) throw new ArgumentException("Line of businesses cannot be empty");

			var country = await countryRepository.Get(countryId);

            if(country is null) throw new ArgumentException($"Country with key {countryId} not found");

			var lineOfBusinesses = await lineOfBusinessRepository.Get(lineOfBusinessIds);

            if(lineOfBusinessIds.Length != lineOfBusinesses.Count) throw new ArgumentException("Line of business not found");
			// Raw value data without other info
            // !! Hardcoded filter because no requirement from user in task
            var rawData = await repository.Get(countryId, lineOfBusinessIds, new DateTime(2008, 1, 1), new DateTime(2015, 12, 31));
			// We join in memory because we already have the entities loaded for check of existence
			// Mapping should be done by mapper or something like that
			return
			 rawData.Join(
				lineOfBusinesses,
				g => g.LineOfBusinessId, l => l.Id,
				(g, l) => new AverageGrossWrittenPremiumDto(l.Name, g.Value)).ToList();
		}
	}
}