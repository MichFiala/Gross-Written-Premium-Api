namespace Domain
{
	public class GrossWrittenPremium
    {
        public int Id { get; set; }
		public int CountryId { get; set; }
        public int LineOfBusinessId { get; set; }
		public DateTime DateTime { get; set; }
        public double Value { get; set; }
        public Country Country { get; set; }
        public LineOfBusiness LineOfBusiness { get; set; }
	}
}