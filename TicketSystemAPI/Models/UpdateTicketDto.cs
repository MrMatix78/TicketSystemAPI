using System;

namespace TicketSystemAPI.Models
{
    public class UpdateTicketDto
    {
        public int EmployeeId { get; set; }
        public int ClientId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TicketTypeId { get; set; }
    }
}
