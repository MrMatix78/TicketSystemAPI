namespace TicketSystemAPI.Entities
{
    public class ClientAddress
    {
        public int Id{ get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }

        public virtual Client Client { get; set; }
    }
}
