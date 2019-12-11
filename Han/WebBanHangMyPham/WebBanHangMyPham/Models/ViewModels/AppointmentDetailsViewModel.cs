using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHangMyPham.Models.ViewModels
{
    public class AppointmentDetailsViewModel
    {
        public Appointments Appointment { get; set; }
        public List<ApplicationUser> NguoiBanHang { get; set; }
        public List<ThongTinSanPham> SanPham { get; set; }
    }
}
