using System.Collections.Generic;
using TicketSystemAPI.Models;

namespace TicketSystemAPI.Interfaces
{
    public interface IClientService
    {
        IEnumerable<ClientDto> GetAll();
        ClientDto GetById(int id);
        int Create(CreateClientDto dto);
        bool Delete(int id);

    }
}
