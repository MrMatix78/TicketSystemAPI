using System.Collections.Generic;
using TicketSystemAPI.Models;

namespace TicketSystemAPI.Interfaces
{
    public interface ITicketService
    {
        IEnumerable<TicketDto> GetAll();
        TicketDto GetById(int id);
        int Create(CreateTicketDto dto);
        bool UpdateStatus(int id, UpdateTicketStatusDto dto);
        bool UpdateTicket(int id, UpdateTicketDto dto);
        bool Delete(int id); 
    }
}
