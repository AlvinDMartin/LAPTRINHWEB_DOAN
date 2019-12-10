using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHangMyPham.Models
{
    public class DangNhap
    {
        public int Id { get; set; }
        [Required]
        public string TenDangNhap { get; set; }
        [Required]
        public string PassWord { get; set; }
        [Required]
        public string User { get; set; }
    }
}
