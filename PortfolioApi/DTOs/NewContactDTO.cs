using System.Text.Json.Serialization;

namespace PortfolioApi.DTOs
{
    public class NewContactDTO
    {
        [JsonPropertyName("company")]
        public string Company { get; set; }

        [JsonPropertyName("firstname")]
        public string FirstName { get; set; }

        [JsonPropertyName("lastname")]
        public string LastName { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("zip")]
        public string Zip { get; set; }

        [JsonPropertyName("phonenumber")]
        public string PhoneNumber { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("comment")]
        public string Comment { get; set; }
    }
}
