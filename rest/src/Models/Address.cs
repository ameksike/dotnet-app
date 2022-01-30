namespace rest.src.Models
{
    public class Address
    {
        public string? street { get; set; }
        public string? suite { get; set; }
        public string? city { get; set; }
        public string? zipcode { get; set; }
        public Geopoint? geo { get; set; }
    }
}