using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.DAL;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class UserService : IUserService
    {
        private readonly IUserDAL _iUserDAL;

        public UserService(IUserDAL iUserDAL)
        {
            _iUserDAL = iUserDAL;  
        }


        public Task<int?> GetUserAsync(string userName, string password)
        {
            return _iUserDAL.GetUserAsync(userName, password);
        }



        
        

    }
}
