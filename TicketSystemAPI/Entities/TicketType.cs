namespace TicketSystemAPI.Entities
{
    public class TicketType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual Ticket Ticket { get; set; }
    }
}
