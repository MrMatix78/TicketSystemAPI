using System.Collections.Generic;
using TicketSystemAPI.Models;

namespace TicketSystemAPI.Interfaces
{
    public interface ITicketService
    {
        IEnumerable<TicketDto> GetAll();
        TicketDto GetById(int id);
        int Create(CreateTicketDto dto);
    }
}
