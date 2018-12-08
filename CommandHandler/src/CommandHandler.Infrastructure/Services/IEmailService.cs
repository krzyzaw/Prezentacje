using System.Threading.Tasks;

namespace CommandHandler.Infrastructure.Services
{
    public interface IEmailService : IService
    {
        Task SendAsync();
    }
}