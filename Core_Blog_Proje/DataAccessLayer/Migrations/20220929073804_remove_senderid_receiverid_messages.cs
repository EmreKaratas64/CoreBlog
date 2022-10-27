using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class remove_senderid_receiverid_messages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReceiverID",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "SenderID",
                table: "Messages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReceiverID",
                table: "Messages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SenderID",
                table: "Messages",
                type: "int",
                nullable: true);
        }
    }
}
