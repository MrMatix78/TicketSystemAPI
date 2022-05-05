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
    }
}
