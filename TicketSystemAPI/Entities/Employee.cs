using System;

namespace TicketSystemAPI.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeAddressId { get; set; }
        public string ContactEmail { get; set; }
        public string ContactNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public virtual EmployeeAddress EmployeeAddress { get; set; }
    }
}
