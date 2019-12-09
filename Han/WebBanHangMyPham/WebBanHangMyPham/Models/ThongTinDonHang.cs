using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHangMyPham.Models
{
    public class ThongTinDonHang
    {
        [Key]
        public int MaDonHang { get; set; }
        [Required]
        public string SoLuong { get; set; }
        [Required]
        public string Gia { get; set; }

    }
}
