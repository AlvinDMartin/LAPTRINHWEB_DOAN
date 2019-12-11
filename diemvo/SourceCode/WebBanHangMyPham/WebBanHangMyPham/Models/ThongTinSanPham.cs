using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHangMyPham.Models
{
    public class ThongTinSanPham
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Tên sản phẩm")]
        public string TenSanPham { get; set; }
        [Required]
        [Display(Name = "Giá")]
        public int DonGia { get; set; }
        [Required]
        [Display(Name = "Hãng sản xuất")]
        public string HangSanXuat { get; set; }
        [Display(Name = "Tên loại sản phẩm")]
        public int LoaiSanPhamId { get; set; }
        [ForeignKey("LoaiSanPhamId")]
        public virtual ThongTinLoaiSanPham ThongTinLoaiSanPham { get; set; }

    }
}
