using AutoMapper;
using TicketSystemAPI.Entities;
using TicketSystemAPI.Models;

namespace TicketSystemAPI.Profiles
{
    public class TicketsProfile : Profile
    {
        public TicketsProfile()
        {
            CreateMap<Ticket, TicketDto>()
                .ForMember(m => m.ClientName, c => c.MapFrom(s => s.Client.Name))
                .ForMember(m => m.Login, c => c.MapFrom(s => s.Employee.Login))
                .ForMember(m => m.TicketTypeName, c => c.MapFrom(s => s.TicketType.Name));

            CreateMap<CreateTicketDto, Ticket>();
        }
    }
}
