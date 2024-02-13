using EcommerceNet.Domain.Entities;

namespace EcommerceNet.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        Customer GetCustomerById(int id);
        Customer GetCustomerByUserId(int userId);
        Task<IEnumerable<Customer>> GetCustomers(); // should we return all customers? or should we add a filter?
        Task<Customer> CreateCustomer(Customer customer);
        Task<Customer> UpdateCustomer(Customer customer);
        Task<Customer> DeleteCustomer(int customerId);
    }
}
