using System.Threading.Tasks;
using CommandHandler.Infrastructure.Commands;
using CommandHandler.Infrastructure.Commands.Leads;
using CommandHandler.Infrastructure.Services;

namespace CommandHandler.Infrastructure.Handlers
{
    public class CreateLeadHandler : ICommandHandler<CreateLead>
    {
        private readonly ILeadService _leadService;

        public CreateLeadHandler(ILeadService leadService)
        {
            _leadService = leadService;
        }

        public async Task HandleAsync(CreateLead command)
        {
            await _leadService.CreateLeadAsync(command);
        }
    }
}