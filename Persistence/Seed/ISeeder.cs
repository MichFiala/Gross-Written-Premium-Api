using Domain;

namespace Persistence.Seed
{
	public interface ISeeder
    {
		IEnumerable<Country> Countries { get; }
        IEnumerable<LineOfBusiness> LineOfBusinesses { get; }
        IEnumerable<GrossWrittenPremium> GrossWrittenPremia { get; }
	}
}