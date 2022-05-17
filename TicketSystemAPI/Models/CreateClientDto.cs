namespace TicketSystemAPI.Models
{
    public class CreateClientDto
    {
        public string Name { get; set; }
        public string NIP { get; set; }
        public string ContactEmail { get; set; }
        public string ContactNumber { get; set; }
        //Client Address
        public string City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
    }
}
