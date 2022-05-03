using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TicketSystemAPI.Entities;
using TicketSystemAPI.Interfaces;
using TicketSystemAPI.Models;

namespace TicketSystemAPI.Services
{
    public class TicketService : ITicketService
    {
        private readonly TicketSystemDbContext _dbContext;
        private readonly IMapper _mapper;

        public TicketService(TicketSystemDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public int Create(CreateTicketDto dto)
        {
            var ticket = _mapper.Map<Ticket>(dto);
            _dbContext.Tickets.Add(ticket);
            _dbContext.SaveChanges();

            return ticket.Id;
        }

        public bool Delete(int id)
        {
            var ticket = _dbContext.Tickets
                .FirstOrDefault(t => t.Id == id);

            if(ticket is null)
                return false;

            _dbContext.Tickets.Remove(ticket);
            _dbContext.SaveChanges();

            return true;

        }

        public IEnumerable<TicketDto> GetAll()
        {
            var tickets = _dbContext.Tickets
                .Include(r => r.Employee)
                .Include(r => r.Client)
                .Include(r => r.TicketType)
                .ToList();

            var ticketsDtos = _mapper.Map<List<TicketDto>>(tickets);

            return ticketsDtos;
        }

        public TicketDto GetById(int id)
        {
            var ticket = _dbContext.Tickets
                .Include(r => r.Employee)
                .Include(r => r.Client)
                .Include(r => r.TicketType)
                .FirstOrDefault(r => r.Id == id);

            var result = _mapper.Map<TicketDto>(ticket);

            return result;
        }

        public bool UpdateStatus(int id, UpdateTicketStatusDto dto)
        {
            var ticket = _dbContext.Tickets
                .FirstOrDefault(r => r.Id == id);

            if (ticket is null)
                return false;

            ticket.Status = dto.Status;
            _dbContext.SaveChanges();

            return true;
        }

        public bool UpdateTicket(int id, UpdateTicketDto dto)
        {
            var ticket = _dbContext.Tickets
                .FirstOrDefault(r => r.Id == id);

            if (ticket is null)
                return false;

            ticket.EmployeeId = dto.EmployeeId;
            ticket.ClientId = dto.ClientId;
            ticket.Title = dto.Title;
            ticket.Content = dto.Content;
            ticket.StartDate = dto.StartDate;
            ticket.EndDate = dto.EndDate;
            ticket.TicketTypeId = dto.TicketTypeId;
            _dbContext.SaveChanges();

            return true;
        }
    }
}
