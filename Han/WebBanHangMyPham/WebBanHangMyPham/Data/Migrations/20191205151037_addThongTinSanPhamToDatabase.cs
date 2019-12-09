using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBanHangMyPham.Data.Migrations
{
    public partial class addThongTinSanPhamToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ThongTinSanPham",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSanPham = table.Column<string>(nullable: false),
                    DonGia = table.Column<int>(nullable: false),
                    HangSanXuat = table.Column<string>(nullable: false),
                    LoaiSanPhamId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinSanPham", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ThongTinSanPham_ThongTinLoaiSanPham_LoaiSanPhamId",
                        column: x => x.LoaiSanPhamId,
                        principalTable: "ThongTinLoaiSanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinSanPham_LoaiSanPhamId",
                table: "ThongTinSanPham",
                column: "LoaiSanPhamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ThongTinSanPham");
        }
    }
}
