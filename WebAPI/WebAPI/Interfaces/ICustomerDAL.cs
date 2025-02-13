using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Interfaces
{
    public interface ICustomerDAL
    {
        Task<Customer> GetCustomerByIdAsync(int customerId);
        Task<bool> IsCustomerNumberAlreadyExistAsync(int customerId);
        Task<List<Customer>> GetCustomersAsync();
        Task AddCustomerAsync(Customer customer);
        Task UpdateCustomerAsync(Customer customer);
        Task DeleteCustomerAsync(int customerId);
    }
}
