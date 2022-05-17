using AutoMapper;
using TicketSystemAPI.Entities;
using TicketSystemAPI.Models;

namespace TicketSystemAPI.Profiles
{
    public class ClientsProfile : Profile
    {
        public ClientsProfile()
        {
            CreateMap<Client, ClientDto>()
                .ForMember(m => m.City, c => c.MapFrom(s => s.ClientAddress.City))
                .ForMember(m => m.Street, c => c.MapFrom(s => s.ClientAddress.Street))
                .ForMember(m => m.PostalCode, c => c.MapFrom(s => s.ClientAddress.PostalCode));

            CreateMap<CreateClientDto, Client>()
                .ForMember(r => r.ClientAddress,
                    c => c.MapFrom(dto => new ClientAddress()
                    {
                        City = dto.City,
                        PostalCode = dto.PostalCode,
                        Street = dto.Street
                    }));
        }
    }
}
