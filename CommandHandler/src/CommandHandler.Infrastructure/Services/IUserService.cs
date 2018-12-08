using System.Threading.Tasks;
using CommandHandler.Infrastructure.DTO;

namespace CommandHandler.Infrastructure.Services
{
    public interface IUserService : IService
    {
        Task<UserDto> GetAsync(string email);
        Task RegisterAsync(string email, string password, string username);
    }
}