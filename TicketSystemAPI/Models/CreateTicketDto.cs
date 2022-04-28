using System;

namespace TicketSystemAPI.Models
{
    public class CreateTicketDto
    {
        public int EmployeeId { get; set; }
        public int ClientId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime StartDate { get; set; }
        public string Status { get; set; }
        public int TicketTypeId { get; set; }
    }
}
