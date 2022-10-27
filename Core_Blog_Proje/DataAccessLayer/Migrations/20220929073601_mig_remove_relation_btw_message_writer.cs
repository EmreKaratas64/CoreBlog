using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_remove_relation_btw_message_writer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Writers_ReceiverID",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Writers_SenderID",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ReceiverID",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_SenderID",
                table: "Messages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReceiverID",
                table: "Messages",
                column: "ReceiverID");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderID",
                table: "Messages",
                column: "SenderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Writers_ReceiverID",
                table: "Messages",
                column: "ReceiverID",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Writers_SenderID",
                table: "Messages",
                column: "SenderID",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
