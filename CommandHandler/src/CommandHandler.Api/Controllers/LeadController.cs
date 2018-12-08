using System.Threading.Tasks;
using CommandHandler.Infrastructure.Commands;
using CommandHandler.Infrastructure.Commands.Leads;
using Microsoft.AspNetCore.Mvc;

namespace CommandHandler.Api.Controllers
{
    [Route("[controller]")]
    public class LeadController : ControllerBase
    {
        private readonly ICommandDispatcher _commandDispatcher;

        public LeadController(ICommandDispatcher commandDispatcher)
        {
            _commandDispatcher = commandDispatcher;
        }

        // POST 
        [HttpPost("{create}")]
        public async Task<IActionResult> Create([FromBody] CreateLead command)
        {
            await _commandDispatcher.DispatchAsync(command);

            return StatusCode(201);
        }
    }
}