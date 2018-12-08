using System.Threading.Tasks;
using CommandHandler.Infrastructure.Commands;
using CommandHandler.Infrastructure.Commands.Forms;
using Microsoft.AspNetCore.Mvc;

namespace CommandHandler.Api.Controllers
{
    public class CustomerServiceController : ApiControllerBase
    {
        public CustomerServiceController(ICommandDispatcher commandDispatcher) : base(commandDispatcher)
        {
        }

        // POST 
        [HttpPost("{contactrequest}")]
        public async Task<IActionResult> ContactRequest([FromBody] CreateContactRequest command)
        {
            await CommandDispatcher.DispatchAsync(command);
            return StatusCode(201);
        }
    }
}