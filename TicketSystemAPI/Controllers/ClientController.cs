using Microsoft.AspNetCore.Mvc;
using TicketSystemAPI.Interfaces;

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
    }
}
