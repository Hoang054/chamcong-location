using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recruit.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class update2905 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "D1",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.DropColumn(
                name: "D10",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.DropColumn(
                name: "D11",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.DropColumn(
                name: "D12",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.DropColumn(
                name: "D13",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.DropColumn(
                name: "D14",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.DropColumn(
                name: "D15",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.DropColumn(
                name: "D16",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.DropColumn(
                name: "D17",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.DropColumn(
                name: "D18",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.DropColumn(
                name: "D19",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.DropColumn(
                name: "D2",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.DropColumn(
                name: "D20",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.DropColumn(
                name: "D21",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.DropColumn(
                name: "D22",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.DropColumn(
                name: "D23",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.DropColumn(
                name: "D24",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.DropColumn(
                name: "D25",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.DropColumn(
                name: "D26",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.DropColumn(
                name: "D27",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.DropColumn(
                name: "D28",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.DropColumn(
                name: "D29",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.DropColumn(
                name: "D3",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.DropColumn(
                name: "D30",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.DropColumn(
                name: "D31",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.DropColumn(
                name: "D4",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.DropColumn(
                name: "D5",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.DropColumn(
                name: "D6",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.DropColumn(
                name: "D7",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.DropColumn(
                name: "D8",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.RenameColumn(
                name: "D9",
                schema: "dbo",
                table: "BANGCHAMCONG",
                newName: "TrangThai");

            migrationBuilder.AddColumn<DateTime>(
                name: "Ngay",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ngay",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.RenameColumn(
                name: "TrangThai",
                schema: "dbo",
                table: "BANGCHAMCONG",
                newName: "D9");

            migrationBuilder.AddColumn<string>(
                name: "D1",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "D10",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "D11",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "D12",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "D13",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "D14",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "D15",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "D16",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "D17",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "D18",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "D19",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "D2",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "D20",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "D21",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "D22",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "D23",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "D24",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "D25",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "D26",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "D27",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "D28",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "D29",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "D3",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "D30",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "D31",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "D4",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "D5",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "D6",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "D7",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "D8",
                schema: "dbo",
                table: "BANGCHAMCONG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
