using System.Threading.Tasks;

namespace CommandHandler.Infrastructure.Services
{
    public class EmailService : IEmailService
    {
        public Task SendAsync()
        {
            return Task.CompletedTask;
        }
    }
}