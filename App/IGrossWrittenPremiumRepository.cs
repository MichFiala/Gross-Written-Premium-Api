using Domain;

namespace App
{
	public interface IGrossWrittenPremiumRepository
	{
		Task<List<GrossWrittenPremium>> Get();
		Task<List<GrossWrittenPremium>> Get(int countryId, int[] lineOfBusinesses, DateTime from, DateTime to);
	}
}