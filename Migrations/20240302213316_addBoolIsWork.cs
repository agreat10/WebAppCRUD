using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppCRUD.Migrations
{
    /// <inheritdoc />
    public partial class addBoolIsWork : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IsWork",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsWork",
                table: "User");
        }
    }
}
