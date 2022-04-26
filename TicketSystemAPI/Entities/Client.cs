namespace TicketSystemAPI.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ClientAddressId { get; set; }
        public string ContactEmail { get; set; }
        public string ContactNumber { get; set; }

        public virtual ClientAddress ClientAddress { get; set; }
    }
}
