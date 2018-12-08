using System;
using System.Threading.Tasks;
using CommandHandler.Infrastructure.Commands;
using CommandHandler.Infrastructure.Enums;

namespace CommandHandler.Infrastructure.Services.Factory
{
    public class LeadFactory : ILeadFactory
    {
        private readonly ILeadService _leadService;
        private readonly IEmailService _emailService;

        public LeadFactory(ILeadService leadService, IEmailService emailService)
        {
            _leadService = leadService;
            _emailService = emailService;
        }

        public async Task CreateLeadAsync<T>(T command, LeadType leadType) where T : ICommand
        {
            switch (leadType)
            {
                case LeadType.CallCenter:
                    await _leadService.CreateCallCenterLeadAsync(command);
                    break;
                case LeadType.CustomerSupport:
                    await _emailService.SendAsync();
                    break;
                case LeadType.Order:
                    await _leadService.CreateOrderLeadAsync(command);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(leadType), leadType, null);
            }
        }
    }
}