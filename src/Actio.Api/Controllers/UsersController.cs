namespace Actio.Api.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Actio.Common.Commands;
    using Microsoft.AspNetCore.Mvc;
    using RawRabbit;

    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IBusClient _busClient;
        public UsersController(IBusClient busClient)
        {
            _busClient = busClient;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Post([FromBody]CreateUser command)
        {
           
            await _busClient.PublishAsync(command);

            return Accepted();
        }

    }
}