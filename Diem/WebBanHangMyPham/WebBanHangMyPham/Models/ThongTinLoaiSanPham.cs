using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHangMyPham.Models
{
    public class ThongTinLoaiSanPham
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Tên loại sản phẩm")]
        public string TenLoaiSanPham { get; set; }
    }
}
