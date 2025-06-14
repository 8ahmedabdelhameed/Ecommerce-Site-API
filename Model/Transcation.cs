namespace WebApplication3.Model
{
    public class Transcation
    {
        public int TransId { get; set; }
        public int Amount { get; set; }
        public DateOnly Date { get; set; }
        public int AccountId { get; set; }
        public Account ? Account { get; set; }



    }
}
