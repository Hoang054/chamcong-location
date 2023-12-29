using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recruit.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class Add_LongAndLa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Latitude",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Longitude",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.DropColumn(
                name: "Longitude",
                schema: "dbo",
                table: "BANGCHAMCONG");
        }
    }
}
