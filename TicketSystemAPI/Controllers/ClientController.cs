using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using TicketSystemAPI.Interfaces;
using TicketSystemAPI.Models;

namespace TicketSystemAPI.Controllers
{
    [Route("api/client")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        //View all clients
        [HttpGet]
        public ActionResult<IEnumerable<ClientDto>> GetAll()
        {
            var clientsDtos = _clientService.GetAll();
            return Ok(clientsDtos);
        }

        //View client by Id
        [HttpGet("{id}")]
        public ActionResult<ClientDto> GetById([FromRoute]int id)
        {
            var clientDto = _clientService.GetById(id);

            if (clientDto is null)
                return NotFound();

            return Ok(clientDto);
        }

        //Create new Client
        [HttpPost]
        public ActionResult Create([FromBody] CreateClientDto dto)
        {
            var id = _clientService.Create(dto);

            return Created($"/api/client/{id}", null);
        }
    }
}
