using GraphQLProject.Models;
namespace GraphQLProject.Interfaces
{
    public interface ICustomerRepository
    {
        List<Customer> GetAllCustomers();
        Customer GetCustomerTransactionsById(int CustomerID);
        Customer AddCustmoers(Customer customer);
        Customer UpdateCustomerTransaction(int CustomerID, Customer customer);

        void DeleteCustomerTransaction(int CustomerID);

    }
}
