using App.Models;

namespace App.Services
{
	public interface IGrossWrittenPremiumService
    {
		Task<List<AverageGrossWrittenPremiumDto>> GetAverageGrossPremium(int countryId, int[] lineOfBusinessIds);
	}
}