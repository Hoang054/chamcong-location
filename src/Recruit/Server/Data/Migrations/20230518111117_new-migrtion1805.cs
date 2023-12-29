using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recruit.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class newmigrtion1805 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "NHANVIEN",
                schema: "dbo",
                columns: table => new
                {
                    STT = table.Column<double>(type: "float", nullable: false),
                    MANV = table.Column<string>(name: "MA_NV", type: "nvarchar(max)", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<double>(type: "float", nullable: false),
                    PsnTypeID = table.Column<double>(type: "float", nullable: false),
                    CCHN = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NHANVIEN", x => x.STT);
                });

            migrationBuilder.CreateTable(
                name: "BANGCHAMCONG",
                schema: "dbo",
                columns: table => new
                {
                    STT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MANV = table.Column<string>(name: "MA_NV", type: "nvarchar(max)", nullable: false),
                    Thang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D8 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D9 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D13 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D14 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D15 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D16 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D17 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D18 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D19 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D20 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D21 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D22 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D23 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D24 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D25 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D26 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D27 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D28 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D29 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D30 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D31 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NhanVienSTT = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BANGCHAMCONG", x => x.STT);
                    table.ForeignKey(
                        name: "FK_BANGCHAMCONG_NHANVIEN_NhanVienSTT",
                        column: x => x.NhanVienSTT,
                        principalSchema: "dbo",
                        principalTable: "NHANVIEN",
                        principalColumn: "STT");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BANGCHAMCONG_NhanVienSTT",
                schema: "dbo",
                table: "BANGCHAMCONG",
                column: "NhanVienSTT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BANGCHAMCONG",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "NHANVIEN",
                schema: "dbo");
        }
    }
}
