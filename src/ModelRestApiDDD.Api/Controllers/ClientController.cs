using Microsoft.AspNetCore.Mvc;
using ModelRestApiDDD.Application.Dtos;
using ModelRestApiDDD.Application.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ModelRestApiDDD.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientApplicationService _application;

        public ClientController(IClientApplicationService application)
        {
            _application = application;
        }

        [HttpGet]
        public async Task<IEnumerable<ClientDto>> GetAll()
        {
            return await _application.GetAll();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ClientDto>> GetById(int id)
        {
            var client = await _application.GetById(id);

            if (client == null)
                return NotFound();

            return Ok(client);
        }

        [HttpPost]
        public async Task<ActionResult<ClientDto>> Add(ClientDto clientDto)
        {
            if (clientDto == null)
                return BadRequest("There isn't any data for insert in database");

            await _application.Add(clientDto);

            return Ok(clientDto);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<ClientDto>> Update(int id, ClientDto clientDto)
        {
            if (clientDto == null)
                return BadRequest("There isn't any data for update in database");

            if (clientDto.Id != id)
                return BadRequest("The id provided is different of client's id");

            await _application.Update(clientDto);

            return Ok(clientDto);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Remove(int id)
        {
            var client = await _application.GetById(id);

            if (client == null)
                return NotFound("There isn't any client with id provided");

            await _application.Remove(client);

            return Ok(client);
        }
    }
}
