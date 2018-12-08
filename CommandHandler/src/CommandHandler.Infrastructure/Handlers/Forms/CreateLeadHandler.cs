using System.Threading.Tasks;
using CommandHandler.Infrastructure.Commands;
using CommandHandler.Infrastructure.Commands.Forms;
using CommandHandler.Infrastructure.Enums;
using CommandHandler.Infrastructure.Services.Factory;

namespace CommandHandler.Infrastructure.Handlers.Forms
{
    public class CreateLeadHandler : ICommandHandler<CreateLead>
    {
        private readonly ILeadFactory _leadFactory;

        public CreateLeadHandler(ILeadFactory leadService)
        {
            _leadFactory = leadService;
        }

        public async Task HandleAsync(CreateLead command)
        {
            await _leadFactory.CreateLeadAsync<CreateLead>(command, LeadType.CallCenter);
        }
    }
}