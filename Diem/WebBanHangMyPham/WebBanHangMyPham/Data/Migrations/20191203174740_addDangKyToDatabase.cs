using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBanHangMyPham.Data.Migrations
{
    public partial class addDangKyToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DangKy",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDangNhap = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    HoTen = table.Column<string>(nullable: false),
                    SDT = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    DiaChi = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DangKy", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DangKy");
        }
    }
}
