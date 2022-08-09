namespace Domain
{
	public class CountryLineOfBusiness
    {
        public int CountryId { get; set; }

        public int LineOfBusinessId { get; set; }

        public DateTime DateTime { get; set; }

        public double GrossWrittenPremium { get; set; }

        public Country Country { get; set; }

        public LineOfBusiness LineOfBusiness { get; set; }
	}
}