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

        //View all Ticket
        [HttpGet]
        public ActionResult <IEnumerable<TicketDto>> GetAll()
        {
            var ticketsDtos = _ticketService.GetAll();

            return Ok(ticketsDtos);
        }

        //View Ticket by id
        [HttpGet("{id}")]
        public ActionResult GetById([FromRoute]int id)
        {
            var ticketDto = _ticketService.GetById(id);
            return Ok(ticketDto);
        }

        //Create new Ticket
        [HttpPost]
        public ActionResult Create([FromBody]CreateTicketDto dto)
        {
            var id = _ticketService.Create(dto);

            return Created($"/api/ticket/{id}", null);
        }

        //Update the Ticket status
        [HttpPut("status/{id}")]
        public ActionResult UpdateStatus([FromRoute]int id, [FromBody]UpdateTicketStatusDto dto)
        {
            var statusUpdate = _ticketService.UpdateStatus(id, dto); 
            
            if (!statusUpdate)
                return NotFound();

            return Ok();
        }
    }
}
