namespace PortfolioApi.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Company { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }
    
        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Comment { get; set; }
    }
}
