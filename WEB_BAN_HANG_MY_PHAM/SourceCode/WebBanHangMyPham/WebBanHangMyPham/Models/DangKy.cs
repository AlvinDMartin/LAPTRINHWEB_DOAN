using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHangMyPham.Models
{
    public class DangKy
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Tên Đăng Nhập")]
        public string TenDangNhap { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]

        [Display(Name ="Tên Khách Hàng")]
        public string HoTen { get; set; }
        [Required]
        [Display(Name = "Số Điện Thoại")]
        public int SDT { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Địa Chỉ")]
        public string DiaChi { get; set; }
    }
}
