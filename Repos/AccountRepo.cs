using WebApplication3.Dtos;
using WebApplication3.Interfaces;
using WebApplication3.Model;

namespace WebApplication3.Repos
{
    public class AccountRepo : IAccount
    {
        private readonly AppDbContext _context;

        public AccountRepo(AppDbContext context)
        {
            _context = context;
        }

        public void AccountDelete(int id)
        {
            var account = _context.Account.Find(id);
            if (account == null)
            {
                throw new ArgumentNullException(nameof(account), "Account cannot be null.");
            }
            else
            {
                _context.Remove(account);
                _context.SaveChanges();
            }
        }

        public void AccountUpdate(AccountpostForCustomer x, int id)
        {
           var Account = _context.Account.Find(id);
            if (Account == null)
            {
                throw new ArgumentNullException(nameof(Account));
            }
            else
            {
                Account.AccNumber = x.AccNumber;
                Account.balance = x.balance;
                Account.Transcation = x.TransGetOrPost == null ? new List<Transcation>() : x.TransGetOrPost.Select(x => new Transcation
                {
                    Amount = x.Amount,
                    Date = x.Date,
                }).ToList();
                Account.Customer = new Customer
                {
                    CustomerEmail = x.Customer.CustomerEmail,
                    CustomerPhone = x.Customer.CustomerPhone,
                    CustomerName = x.Customer.CustomerName,
                    BankCard = x.Customer.BankCard == null ? new BankCard() : new BankCard()
                    {
                        BankCardNumber = x.Customer.BankCard.BankCardNumber,
                        DateOnly = x.Customer.BankCard.DateOnly,
                    }
                };
                _context.Update(Account);
                _context.SaveChanges();

            }
        }
        

        public List<AccountGetWithCustomerAndTrans> GetAllAccount()
        {
            return _context.Account.Select(x=> new AccountGetWithCustomerAndTrans
            {
                AccNumber = x.AccNumber,
                AccountId = x.AccountId,   
                balance = x.balance,
                TransGetOrPost = x.Transcation == null ?  new  List<TransGetOrPost>() :  x.Transcation.Select(x=> new TransGetOrPost
                {
                    Amount = x.Amount,
                    Date = x.Date,
                }).ToList(),
                Customer =  new CustomerGetWithAndCard
                {
                    CustomerEmail = x.Customer.CustomerEmail,
                    CustomerPhone = x.Customer.CustomerPhone,
                    CustomerName = x.Customer.CustomerName,
                    CustomerId = x.Customer.CustomerId,
                    BankCard = x.Customer.BankCard == null ? new BankCardGet() : new BankCardGet()
                    {
                        BankCardNumber = x.Customer.BankCard.BankCardNumber,
                        DateOnly = x.Customer.BankCard.DateOnly,
                    }
                }

            }).ToList();
        }

        public void PostAccount(AccountpostForCustomer accountpostForCustomer, int id)
        {

            Account account = new Account
            {
                AccNumber = accountpostForCustomer.AccNumber,
                balance = accountpostForCustomer.balance,
                Transcation = accountpostForCustomer.TransGetOrPost.Select(x => new Transcation
                {
                    Amount = x.Amount,
                    Date = x.Date
                }).ToList(),
                Customer = new Customer
                {
                    CustomerEmail = accountpostForCustomer.Customer.CustomerEmail,
                    CustomerPhone = accountpostForCustomer.Customer.CustomerPhone,
                    CustomerName = accountpostForCustomer.Customer.CustomerName,
                }
                
            };
            _context.Add(account);
            _context.SaveChanges(); 
        }
    }
}
