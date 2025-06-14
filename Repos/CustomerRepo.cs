using WebApplication3.Dtos;
using WebApplication3.Interfaces;
using WebApplication3.Model;

namespace WebApplication3.Repos
{
    public class CustomerRepo : ICustomer
    {
        private readonly AppDbContext _context;

        public CustomerRepo(AppDbContext context)
        {
            _context = context;
        }

        public List<CustomerGetWithAccountAndCardAndTrans> GetAllCustomer()
        {
            _context.customers.Select(x=> new  CustomerGetWithAccountAndCardAndTrans
            {
                CustomerEmail = x.CustomerEmail,
                CustomerName = x.CustomerName,
                CustomerPhone = x.CustomerPhone,    
                CustomerId = x.CustomerId,  
                BankCard = x.BankCard == null ? new BankCardGet(): new BankCardGet
                {
                    BankCardNumber = x.BankCard.BankCardNumber,
                    DateOnly = x.BankCard.DateOnly, 
                },
                AccountList = x.AccountList.Select(x=> new AccountGetWithTrans
                {
                    AccNumber = x.AccNumber,
                    balance = x.balance,
                    TransGetOrPost = x.Transcation.Select(x=>new TransGetOrPost
                    {
                        Amount = x.Amount,
                        Date =x.Date
                    }).ToList(),
                
            }).ToList()
        }).ToList();

        public CustomerGetWithAccountAndCardAndTrans GetCustomerBYId(int customerId)
        {
                var x= _context.customers.Find(customerId);
                return new CustomerGetWithAccountAndCardAndTrans
                {
                    CustomerEmail = x.CustomerEmail,
                    CustomerName = x.CustomerName,
                    CustomerPhone = x.CustomerPhone,
                    CustomerId = x.CustomerId,
                    BankCard = x.BankCard == null ? new BankCardGet() : new BankCardGet
                    {
                        BankCardNumber = x.BankCard.BankCardNumber,
                        DateOnly = x.BankCard.DateOnly,
                    },
                    AccountList = x.AccountList.Select(x => new AccountGetWithTrans
                    {
                        AccNumber = x.AccNumber,
                        balance = x.balance,
                        TransGetOrPost = x.Transcation.Select(x => new TransGetOrPost
                        {
                            Amount = x.Amount,
                            Date = x.Date
                        }).ToList(),

                    }).ToList()
                };
        }

        public void PostCustomer(CustomerPost customerPost)
        {
                Customer customer = new Customer
                {
                    CustomerEmail = customerPost.CustomerEmail,
                    AccountList = customerPost.AccountList.Select(x=>new Account
                    {
                        balance = x.balance,
                        Transcation
                    })
                }

            }
}
