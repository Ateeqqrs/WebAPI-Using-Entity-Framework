using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerDAL _iCustomerDAL;

        public CustomerService(ICustomerDAL iCustomerDAL)
        {
            _iCustomerDAL = iCustomerDAL;
        }

        public Task<Customer> GetCustomerByIdAsync(int customerId)
        {
            return _iCustomerDAL.GetCustomerByIdAsync(customerId);
        }

        public async Task<List<Customer>> GetCustomersAsync()
        {
            return await _iCustomerDAL.GetCustomersAsync();
        }

        public async Task<bool> IsCustomerNumberAlreadyExistAsync(int customerNumber)
        {
            return await _iCustomerDAL.IsCustomerNumberAlreadyExistAsync(customerNumber);
        }

        public async Task AddCustomerAsync(Customer customer)
        {
            customer.Gender = customer.Gender == "Male" ? "M" : "F";
            await _iCustomerDAL.AddCustomerAsync(customer);
        }

        public async Task UpdateCustomerAsync(Customer customer)
        {
            customer.Gender = customer.Gender == "Male" ? "M" : "F";
            await _iCustomerDAL.UpdateCustomerAsync(customer);
        }

        public async Task DeleteCustomerAsync(int customerId)
        {
            await _iCustomerDAL.DeleteCustomerAsync(customerId);
        }

    }
}
