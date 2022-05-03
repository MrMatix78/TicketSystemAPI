using System;
using System.ComponentModel.DataAnnotations;

namespace TicketSystemAPI.Models
{
    public class UpdateTicketDto
    {
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public int ClientId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Required]
        public int TicketTypeId { get; set; }
    }
}
