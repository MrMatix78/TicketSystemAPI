using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TicketSystemAPI.Interfaces;
using TicketSystemAPI.Models;

namespace TicketSystemAPI.Controllers
{
    [Route("api/ticket")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketService _ticketService;

        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpGet]
        public ActionResult <IEnumerable<TicketDto>> GetAll()
        {
            var ticketsDtos = _ticketService.GetAll();

            return Ok(ticketsDtos);
        }

        [HttpGet("{id}")]
        public ActionResult GetById([FromRoute]int id)
        {
            var ticketDto = _ticketService.GetById(id);
            return Ok(ticketDto);
        }
    }
}
