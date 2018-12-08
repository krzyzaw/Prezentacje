using System.Threading.Tasks;
using CommandHandler.Infrastructure.Commands;
using CommandHandler.Infrastructure.Commands.Forms;
using CommandHandler.Infrastructure.Enums;
using CommandHandler.Infrastructure.Services.Factory;

namespace CommandHandler.Infrastructure.Handlers.Forms
{
    public class CreateOrderHandler : ICommandHandler<CreateOrder>
    {
        private readonly ILeadFactory _leadFactory;

        public CreateOrderHandler(ILeadFactory leadFactory)
        {
            _leadFactory = leadFactory;
        }

        public async Task HandleAsync(CreateOrder command)
        {
            await _leadFactory.CreateLeadAsync(command, LeadType.Order);
        }
    }
}