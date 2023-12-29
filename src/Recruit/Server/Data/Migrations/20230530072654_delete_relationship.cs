using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recruit.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class delete_relationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BANGCHAMCONG_NHANVIEN_NhanVienSTT",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.RenameColumn(
                name: "NhanVienSTT",
                schema: "dbo",
                table: "BANGCHAMCONG",
                newName: "NhanVienDbSTT");

            migrationBuilder.RenameIndex(
                name: "IX_BANGCHAMCONG_NhanVienSTT",
                schema: "dbo",
                table: "BANGCHAMCONG",
                newName: "IX_BANGCHAMCONG_NhanVienDbSTT");

            migrationBuilder.AddForeignKey(
                name: "FK_BANGCHAMCONG_NHANVIEN_NhanVienDbSTT",
                schema: "dbo",
                table: "BANGCHAMCONG",
                column: "NhanVienDbSTT",
                principalSchema: "dbo",
                principalTable: "NHANVIEN",
                principalColumn: "STT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BANGCHAMCONG_NHANVIEN_NhanVienDbSTT",
                schema: "dbo",
                table: "BANGCHAMCONG");

            migrationBuilder.RenameColumn(
                name: "NhanVienDbSTT",
                schema: "dbo",
                table: "BANGCHAMCONG",
                newName: "NhanVienSTT");

            migrationBuilder.RenameIndex(
                name: "IX_BANGCHAMCONG_NhanVienDbSTT",
                schema: "dbo",
                table: "BANGCHAMCONG",
                newName: "IX_BANGCHAMCONG_NhanVienSTT");

            migrationBuilder.AddForeignKey(
                name: "FK_BANGCHAMCONG_NHANVIEN_NhanVienSTT",
                schema: "dbo",
                table: "BANGCHAMCONG",
                column: "NhanVienSTT",
                principalSchema: "dbo",
                principalTable: "NHANVIEN",
                principalColumn: "STT");
        }
    }
}
