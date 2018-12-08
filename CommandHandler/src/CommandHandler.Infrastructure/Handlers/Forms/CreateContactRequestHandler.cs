using System.Threading.Tasks;
using CommandHandler.Infrastructure.Commands;
using CommandHandler.Infrastructure.Commands.Forms;
using CommandHandler.Infrastructure.Enums;
using CommandHandler.Infrastructure.Services.Factory;

namespace CommandHandler.Infrastructure.Handlers.Forms
{
    public class CreateContactRequestHandler : ICommandHandler<CreateContactRequest>
    {
        private readonly ILeadFactory _leadFactory;

        public CreateContactRequestHandler(ILeadFactory leadService)
        {
            _leadFactory = leadService;
        }

        public async Task HandleAsync(CreateContactRequest command)
        {
            await _leadFactory.CreateLeadAsync(command, LeadType.CustomerSupport);
        }
    }
}