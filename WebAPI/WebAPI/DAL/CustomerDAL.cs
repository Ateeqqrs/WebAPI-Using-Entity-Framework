using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.DAL
{
    public class CustomerDAL : ICustomerDAL
    {
        public IConfiguration Configuration { get; }
        private DBContext _dbContext;

        public CustomerDAL(IConfiguration configuration, DBContext customerDbContext)
        {
            Configuration = configuration;
            _dbContext = customerDbContext;
        }
        public async Task<Customer> GetCustomerByIdAsync(int customerId)
        {
            Customer customer = await _dbContext.Customer.SingleOrDefaultAsync(s => s.CustomerId == customerId);
            return customer;
        }

        public async Task<bool> IsCustomerNumberAlreadyExistAsync(int customerNumber)
        {
            Customer customer = await _dbContext.Customer.SingleOrDefaultAsync(s => s.CustomerNumber == customerNumber);
            if (customer == null)
            {
                return false;
            }
            return true;
        }

        public async Task<List<Customer>> GetCustomersAsync()
        {
            return await _dbContext.Customer.ToListAsync();
        }

        public async Task AddCustomerAsync(Customer customer)
        {
            _dbContext.Entry(customer).State = EntityState.Added;
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateCustomerAsync(Customer customer)
        {
            _dbContext.Entry(customer).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteCustomerAsync(int customerId)
        {
            Customer customer = await GetCustomerByIdAsync(customerId);
            _dbContext.Remove(customer);
            await _dbContext.SaveChangesAsync();
        }
    }
}


