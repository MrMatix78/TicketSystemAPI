using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TicketSystemAPI.Entities;
using TicketSystemAPI.Interfaces;
using TicketSystemAPI.Models;

namespace TicketSystemAPI.Services
{
    public class ClientService : IClientService
    {
        private readonly TicketSystemDbContext _dbContext;
        private readonly IMapper _mapper;

        public ClientService(TicketSystemDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public IEnumerable<ClientDto> GetAll()
        {
            var clients = _dbContext.Clients
                .Include(r => r.ClientAddress)
                .ToList();
            
            var clientsDto = _mapper.Map<List<ClientDto>>(clients);

            return clientsDto;
        }
    }
}
