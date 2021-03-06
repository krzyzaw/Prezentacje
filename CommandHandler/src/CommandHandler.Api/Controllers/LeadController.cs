﻿using System.Threading.Tasks;
using CommandHandler.Infrastructure.Commands;
using CommandHandler.Infrastructure.Commands.Forms;
using Microsoft.AspNetCore.Mvc;

namespace CommandHandler.Api.Controllers
{
    [Route("[controller]")]
    public class LeadController : ApiControllerBase
    {
        public LeadController(ICommandDispatcher commandDispatcher) : base(commandDispatcher)
        {
        }

        // POST 
        [HttpPost("{create}")]
        public async Task<IActionResult> Create([FromBody] CreateLead command)
        {
            await CommandDispatcher.DispatchAsync(command);
            return StatusCode(201);
        }
    }
}