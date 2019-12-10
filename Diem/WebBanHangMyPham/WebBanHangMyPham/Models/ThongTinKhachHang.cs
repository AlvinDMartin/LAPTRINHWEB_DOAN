using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHangMyPham.Models
{
    public class ThongTinKhachHang
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Tên khách hàng")]
        public string TenKhachHang { get; set; }
        [Required]
        [Display(Name = "Số điện thoại")]
        public string SDT { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }
    }
}
