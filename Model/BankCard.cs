namespace WebApplication3.Model
{
    public class BankCard
    {
        public int BankCardId { get; set; }
        public string BankCardNumber { get; set; }
        public DateOnly DateOnly { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }


    }
}
