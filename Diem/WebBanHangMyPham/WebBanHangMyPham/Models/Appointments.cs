using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHangMyPham.Models
{
    public class Appointments
    {
        public int Id { get; set; }
        public DateTime NgayMuaHang { get; set; }
        [NotMapped]
        public DateTime GioMuaHang { get; set; }
        public string TenKhachHang { get; set; }
        public string SdtKhachHang { get; set; }
        public string EmailKhachHang { get; set; }
        public bool XacNhan { get; set; }
    }
}
