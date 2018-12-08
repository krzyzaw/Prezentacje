using System.Threading.Tasks;
using CommandHandler.Infrastructure.Commands;
using CommandHandler.Infrastructure.Commands.Forms;
using Microsoft.AspNetCore.Mvc;

namespace CommandHandler.Api.Controllers
{
    public class OrderController : ApiControllerBase
    {
        public OrderController(ICommandDispatcher commandDispatcher) : base(commandDispatcher)
        {
        }

        // POST 
        [HttpPost("{create}")]
        public async Task<IActionResult> Create([FromBody] CreateOrder command)
        {
            await CommandDispatcher.DispatchAsync(command);
            return StatusCode(201);
        }
    }
}