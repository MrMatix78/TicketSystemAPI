using Microsoft.EntityFrameworkCore;

namespace TicketSystemAPI.Entities
{
    public class TicketSystemDbContext : DbContext
    {
        public TicketSystemDbContext(DbContextOptions<TicketSystemDbContext> options) :base(options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketType> TicketTypes { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeAddress> EmployeeAddresses { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientAddress> ClientAddresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>()
                .Property(t => t.EmployeeId)
                .IsRequired();
            modelBuilder.Entity<Ticket>()
                .Property(t => t.ClientId)
                .IsRequired();
            modelBuilder.Entity<Ticket>()
                .Property(t => t.TicketTypeId)
                .IsRequired();
            modelBuilder.Entity<Ticket>()
                .Property(t => t.Title)
                .IsRequired();
        }
    }
}
