using AutoMapper;
using TicketSystemAPI.Entities;
using TicketSystemAPI.Interfaces;

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
    }
}
