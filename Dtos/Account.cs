using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Dtos
{
    public class AccountGet
    {
        public int balance { get; set; }
        public string AccNumber { get; set; }

    }
    public class AccountGetWithTrans
    {
        public int balance { get; set; }
        public string AccNumber { get; set; }
        public List<TransGetOrPost> TransGetOrPost { get; set; }

    }
    public class AccountGetWithCustomerAndTrans
    {
        public int AccountId { get; set; }
        public int balance { get; set; }
        public string AccNumber { get; set; }
        public CustomerGetWithAndCard Customer{ get; set; }
        public List<TransGetOrPost> TransGetOrPost { get; set; }
    }
    public class AccountpostForCustomer
    {
        public int balance { get; set; }
        public string AccNumber { get; set; }
        [Required]
        public CustomerGetWithAndCardforAccount Customer { get; set; }
        public List<TransGetOrPost> TransGetOrPost { get; set; }
    }

}
