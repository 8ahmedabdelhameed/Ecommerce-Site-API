using WebApplication3.Dtos;

namespace WebApplication3.Interfaces
{
    public interface ICustomer
    {
        List<CustomerGetWithAccountAndCardAndTrans> GetAllCustomer();
        void PostCustomer(CustomerPost customerPost);
        CustomerGetWithAccountAndCardAndTrans GetCustomerBYId(int customerId);

    }
}
