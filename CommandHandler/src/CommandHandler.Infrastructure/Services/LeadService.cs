using System.Threading.Tasks;
using CommandHandler.Infrastructure.Commands;

namespace CommandHandler.Infrastructure.Services
{
    public class LeadService : ILeadService
    {
        public Task CreateLeadAsync(ICommand lead)
        {
            return Task.CompletedTask;
        }
    }
}