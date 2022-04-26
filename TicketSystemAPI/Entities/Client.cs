namespace TicketSystemAPI.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NIP { get; set; }
        public int ClientAddressId { get; set; }
        public string ContactEmail { get; set; }
        public string ContactNumber { get; set; }

        public virtual ClientAddress ClientAddress { get; set; }
    }
}
