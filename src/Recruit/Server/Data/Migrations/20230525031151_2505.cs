using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recruit.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class _2505 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "STT",
                table: "Applicants",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_STT",
                table: "Applicants",
                column: "STT",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Applicants_NHANVIEN_STT",
                table: "Applicants",
                column: "STT",
                principalSchema: "dbo",
                principalTable: "NHANVIEN",
                principalColumn: "STT",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applicants_NHANVIEN_STT",
                table: "Applicants");

            migrationBuilder.DropIndex(
                name: "IX_Applicants_STT",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "STT",
                table: "Applicants");
        }
    }
}
