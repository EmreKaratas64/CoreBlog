using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_remove_blogid_from_blograting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlogID",
                table: "BlogRatings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogID",
                table: "BlogRatings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
