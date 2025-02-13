using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Interfaces
{
    public interface IUserDAL
    {
        Task<int?> GetUserAsync(string userName, string password);
    }
}
