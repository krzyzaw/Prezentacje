using System.Threading.Tasks;
using CommandHandler.Infrastructure.Commands;

namespace CommandHandler.Infrastructure.Services
{
    public class LeadService : ILeadService
    {
        public Task CreateCallCenterLeadAsync(ICommand lead)
        {
            return Task.CompletedTask;
        }

        public Task CreateOrderLeadAsync(ICommand lead)
        {
            return Task.CompletedTask;
        }
    }
}