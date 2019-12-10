using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBanHangMyPham.Data.Migrations
{
    public partial class AddMenuItemToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coupon",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    CouponType = table.Column<string>(nullable: false),
                    Discount = table.Column<double>(nullable: false),
                    MinimumAmount = table.Column<double>(nullable: false),
                    Picture = table.Column<byte[]>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    MoTa = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    LoaiSanPhamId = table.Column<int>(nullable: false),
                    SanPhamId = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuItem_ThongTinLoaiSanPham_LoaiSanPhamId",
                        column: x => x.LoaiSanPhamId,
                        principalTable: "ThongTinLoaiSanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_MenuItem_ThongTinSanPham_SanPhamId",
                        column: x => x.SanPhamId,
                        principalTable: "ThongTinSanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_LoaiSanPhamId",
                table: "MenuItem",
                column: "LoaiSanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_SanPhamId",
                table: "MenuItem",
                column: "SanPhamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coupon");

            migrationBuilder.DropTable(
                name: "MenuItem");

            migrationBuilder.DropTable(
                name: "GiamGia");
        }
    }
}
