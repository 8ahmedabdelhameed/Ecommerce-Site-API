namespace WebApplication3.Dtos
{
    public class CustomerGetWithAccountAndCardAndTrans
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public List<AccountGetWithTrans> AccountList { get; set; }
        public BankCardGet BankCard { get; set; }
    }
    public class CustomerGetWithAndCard
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public BankCardGet BankCard { get; set; }
    }
    public class CustomerGetWithAndCardforAccount
    {
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public BankCardGet BankCard { get; set; }
    }
    public class CustomerPost
    {
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public BankCardGet BankCard { get; set; }
        public List<AccountGet> AccountList { get; set; }
    }
}
