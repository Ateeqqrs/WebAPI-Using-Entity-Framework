using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CustomerController : ControllerBase
    {
        private ICustomerService _iCustomerService;
        public CustomerController(ICustomerService iCustomerService)
        {
            _iCustomerService = iCustomerService;
        }

        [Route("GetCustomerById")]
        public async Task<Customer> GetCustomerByIdAsync(int customerId)
        {
            Customer customers = await _iCustomerService.GetCustomerByIdAsync(customerId);
            return customers;
        }

        [Route("IsCustomerNumberAlreadyExist")]
        public async Task<bool> IsCustomerNumberAlreadyExistAsync(int customerNumber)
        {
            return await _iCustomerService.IsCustomerNumberAlreadyExistAsync(customerNumber);
        }

        
        [Route("GetCustomers")]
        public async Task<List<Customer>> GetCustomersAsync()
        {
            List<Customer> customers = await _iCustomerService.GetCustomersAsync();
            return customers;
        }

        [Route("AddCustomer")]
        public async Task AddCustomerAsync(Customer customer)
        {
            await _iCustomerService.AddCustomerAsync(customer);
        }

        [HttpPut]
        [Route("UpdateCustomer")]
        public async Task UpdateCustomerAsync(Customer customer)
        {
            await _iCustomerService.UpdateCustomerAsync(customer);
        }

        [Route("DeleteCustomer")]
        public async Task DeleteCustomerAsync(int customerId)
        {
            await _iCustomerService.DeleteCustomerAsync(customerId);
        }
    }
}
