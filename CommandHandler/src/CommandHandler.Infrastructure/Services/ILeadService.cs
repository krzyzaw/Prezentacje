using System.Threading.Tasks;
using CommandHandler.Infrastructure.Commands;

namespace CommandHandler.Infrastructure.Services
{
    public interface ILeadService : IService
    {
        Task CreateCallCenterLeadAsync(ICommand lead);
        Task CreateOrderLeadAsync(ICommand lead);
    }
}