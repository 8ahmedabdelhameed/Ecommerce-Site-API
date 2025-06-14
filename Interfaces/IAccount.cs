using WebApplication3.Dtos;

namespace WebApplication3.Interfaces
{
    public interface IAccount
    {
        List<AccountGetWithCustomerAndTrans> GetAllAccount();
        void PostAccount(AccountpostForCustomer accountpostForCustomer,int id);
        void AccountUpdate(AccountpostForCustomer accountpostForCustomer, int id);
        void AccountDelete(int id);
    }
}
