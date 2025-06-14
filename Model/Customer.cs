namespace WebApplication3.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public BankCard BankCard { get; set; }
        public List<Account> AccountList { get; set; }
    }
}
