using System.Threading.Tasks;
using CommandHandler.Infrastructure.Commands;
using CommandHandler.Infrastructure.Enums;

namespace CommandHandler.Infrastructure.Services.Factory
{
    public interface ILeadFactory : IService
    {
        Task CreateLeadAsync<T>(T command, LeadType leadType) where T : ICommand;
    }
}