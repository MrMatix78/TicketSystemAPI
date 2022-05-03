using System;
using System.ComponentModel.DataAnnotations;

namespace TicketSystemAPI.Models
{
    public class CreateTicketDto
    {
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public int ClientId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime StartDate { get; set; }
        public string Status { get; set; }
        [Required]
        public int TicketTypeId { get; set; }
    }
}
