﻿using AutoMapper;
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
    }
}
