using System;

namespace TicketSystemAPI.Models
{
    public class TicketDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }

        //Client information
        public string ClientName { get; set; }

        //Employee information
        public string Login { get; set; }

        //TicketType information
        public string TicketTypeName { get; set; }
    }
}
