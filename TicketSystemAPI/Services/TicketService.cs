using AutoMapper;
using System.Collections.Generic;
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
    }
}
