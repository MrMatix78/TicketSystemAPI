using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketSystemAPI.Migrations
{
    public partial class Modf_Client : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Clients",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Clients",
                newName: "NIP");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Clients",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "NIP",
                table: "Clients",
                newName: "FirstName");
        }
    }
}
