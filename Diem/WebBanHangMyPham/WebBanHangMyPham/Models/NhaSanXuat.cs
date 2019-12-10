using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHangMyPham.Models
{
    public class NhaSanXuat
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Tên nhà sản xuất")]
        public string TenNhaSX { get; set; }
        [Required]
        [Display(Name = "Quốc gia")]
        public string QuocGia { get; set; }
    }
}
