namespace rest.src.Models
{
    public class User
    {
        public string? name { get; set; }
        public string? username { get; set; }
        public string? email { get; set; }
        public string? phone { get; set; }
        public string? website { get; set; }
        public Company? company { get; set; }
        public Address? address { get; set; }
    }
}