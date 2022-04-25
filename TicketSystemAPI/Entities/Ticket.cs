using System;

namespace TicketSystemAPI.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int ClientId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public int TicketTypeId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Client Client { get; set; }
        public virtual TicketType TicketType { get; set; }

    }
}
