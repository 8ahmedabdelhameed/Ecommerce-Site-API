namespace WebApplication3.Model
{
    public class Account
    {
        public int AccountId { get; set; }
        public int balance { get; set; }
        public string AccNumber { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<Transcation> Transcation { get; set; }

    }
}
