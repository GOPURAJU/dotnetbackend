using GraphQLProject.Interfaces;
using GraphQLProject.Models;

namespace GraphQLProject.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        private static List<Customer> CustomeraList = new List<Customer>()
        {
            new Customer() {FirstName="SAI", LastName="test1", Email="test1@gmail.ocm" , Mobile=9879879878},
            new Customer() {FirstName="laxmi", LastName="test2", Email="test2@gmail.ocm" , Mobile=8788788788},
        };
        public Customer AddCustomer(Customer customer)
        {
            CustomeraList.Add(customer);
            return customer;
        }

        public void DeleteCustomer(int customer)
        {
            CustomeraList.RemoveAt(customer);
            
        }

        public List<Customer> GetAllMenu()
        {
            return CustomeraList;
        }

        public Customer GetMenuById(int id)

        {
            return CustomeraList.Find(m => m.CustomerID == id);
        }

        public Customer UpdateMenu(int id, Customer menu)
        {
            CustomeraList[id] = menu;
            return menu;
        }
    }
}
