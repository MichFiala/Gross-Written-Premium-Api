using Domain;

namespace Persistence.Seed
{
	public class Seeder : ISeeder
	{
		public IEnumerable<Country> Countries => new List<Country>
	    {
		    new () { Id = 1, Name = "CZ"},
		    new () { Id = 2, Name = "DE"},
		    new () { Id = 3, Name = "ES"}
	    };
		public IEnumerable<LineOfBusiness> LineOfBusinesses => new List<LineOfBusiness>
		{
		    new() { Id = 1, Name = "Retail"},
		    new() { Id = 2, Name = "Insurance"}
		};
		public IEnumerable<GrossWrittenPremium> GrossWrittenPremia => new List<GrossWrittenPremium>()
	    {
			// CZ - Retail 
			new () { Id  = 1, CountryId = 1, LineOfBusinessId = 1, DateTime = new DateTime(2008, 10, 12), Value = 100.5},
			new () { Id  = 2, CountryId = 1, LineOfBusinessId = 1, DateTime = new DateTime(2010, 8, 29), Value = 120.5},
			new () { Id  = 3, CountryId = 1, LineOfBusinessId = 1, DateTime = new DateTime(2012, 1, 21), Value = 110.5},
			// CZ - Insurance
			new () { Id  = 4, CountryId = 1, LineOfBusinessId = 2, DateTime = new DateTime(2008, 10, 12), Value = 10.5},
			new () { Id  = 5, CountryId = 1, LineOfBusinessId = 2, DateTime = new DateTime(2010, 8, 29), Value = 20.5},
			new () { Id  = 6, CountryId = 1, LineOfBusinessId = 2, DateTime = new DateTime(2012, 1, 21), Value = 10.5},
			// DE - Retail 
			new () { Id  = 7, CountryId = 2, LineOfBusinessId = 1, DateTime = new DateTime(2008, 10, 12), Value = 150.5},
			new () { Id  = 8, CountryId = 2, LineOfBusinessId = 1, DateTime = new DateTime(2010, 8, 29), Value = 220.5},
			new () { Id  = 9, CountryId = 2, LineOfBusinessId = 1, DateTime = new DateTime(2012, 1, 21), Value = 210.5},
			// DE - Insurance 
			new () { Id  = 10, CountryId = 2, LineOfBusinessId = 2, DateTime = new DateTime(2008, 10, 12), Value = 15.5},
			new () { Id  = 11, CountryId = 2, LineOfBusinessId = 2, DateTime = new DateTime(2010, 8, 29), Value = 22.5},
			new () { Id  = 12, CountryId = 2, LineOfBusinessId = 2, DateTime = new DateTime(2012, 1, 21), Value = 21.5},
			// ES - Left empty on purpose
	    };
	}
}