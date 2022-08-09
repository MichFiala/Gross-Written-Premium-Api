using System.Collections.Generic;

namespace Domain
{
	public class Country
    {
        public int Id { get; set; }

        public string Name { get; set; }

		public ICollection<CountryLineOfBusiness> CountryLineOfBusinesses { get; set; } = new List<CountryLineOfBusiness>();
	}
}