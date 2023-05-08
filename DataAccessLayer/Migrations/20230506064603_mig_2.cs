using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Features",
                newName: "ImgUrl");

            migrationBuilder.AddColumn<string>(
                name: "Description1",
                table: "Features",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "NULL");

            migrationBuilder.AddColumn<string>(
                name: "Description2",
                table: "Features",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description1",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "Description2",
                table: "Features");

            migrationBuilder.RenameColumn(
                name: "ImgUrl",
                table: "Features",
                newName: "Description");
        }
    }
}
