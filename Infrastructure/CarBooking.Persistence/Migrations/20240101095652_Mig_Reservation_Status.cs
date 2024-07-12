using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBooking.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_Reservation_Status : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Reservations");
        }
    }
}
