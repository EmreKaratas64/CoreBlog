using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_add_one_to_one_rel_blogs_blogrationgs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogID",
                table: "BlogRatings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BlogRatings_BlogID",
                table: "BlogRatings",
                column: "BlogID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogRatings_Blogs_BlogID",
                table: "BlogRatings",
                column: "BlogID",
                principalTable: "Blogs",
                principalColumn: "BlogID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogRatings_Blogs_BlogID",
                table: "BlogRatings");

            migrationBuilder.DropIndex(
                name: "IX_BlogRatings_BlogID",
                table: "BlogRatings");

            migrationBuilder.DropColumn(
                name: "BlogID",
                table: "BlogRatings");
        }
    }
}
