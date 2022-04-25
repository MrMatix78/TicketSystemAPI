namespace TicketSystemAPI.Entities
{
    public class EmployeeAddress
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
