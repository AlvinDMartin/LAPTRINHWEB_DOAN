using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebBanHangMyPham.Models;

namespace WebBanHangMyPham.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        
        {
        }

        public DbSet<DangKy> DangKy { get; set; }
        public DbSet<ThongTinLoaiSanPham> ThongTinLoaiSanPham { get; set; }
        public DbSet<ThongTinSanPham> ThongTinSanPham { get; set; }
        public DbSet<ThongTinKhachHang> ThongTinKhachHang { get; set; }
        public DbSet<ThongTinDonHang> ThongTinDonHang { get; set; }
        public DbSet<NhaSanXuat> ThongTinNhaSanXuat { get; set; }
        public DbSet<Coupon> Coupon { get; set; }
        public DbSet<MenuItem> MenuItem { get; set; }
    }
}
