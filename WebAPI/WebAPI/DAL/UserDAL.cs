using System.Data.SqlClient;
using System.Data;
using WebAPI.Interfaces;
using WebAPI.Models;
using System;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace WebAPI.DAL
{
    public class UserDAL : IUserDAL
    {
        public IConfiguration Configuration { get; }
        private DBContext _dbContext;
        public UserDAL(IConfiguration configuration, DBContext customerDbContext)
        {
            Configuration = configuration;
            _dbContext = customerDbContext;
        }
        public async Task<int?> GetUserAsync(string userName, string password)
        {
            User user = await _dbContext.User.Where(s => s.UserName == userName && s.Password == password).FirstOrDefaultAsync();
            if (user != null)
            {
                return user.UserId;
            }
            return null;

        }
    }
}
