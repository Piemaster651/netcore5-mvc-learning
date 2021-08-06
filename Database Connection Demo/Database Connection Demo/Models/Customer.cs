namespace Database_Connection_Demo.Models
{
    // POCO
    public class Customer
    {
        public int ID { get; set; }
        public string Alias { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal CreditLimit { get; set; }
    }
}