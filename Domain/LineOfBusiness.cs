namespace Domain
{
	public class LineOfBusiness
    {
        public int Id { get; set; }

        public string Name { get; set; }

		public ICollection<GrossWrittenPremium> CountryLineOfBusinesses { get; set; } = new List<GrossWrittenPremium>();
	}
}