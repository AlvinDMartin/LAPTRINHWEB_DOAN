using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHangMyPham.Models.ViewModels
{
    public class ShippingCartViewModel
    {
        public List<ThongTinSanPham> ThongTinSanPhams { get; set; }
        public Appointments Appointments { get; set; }
    }
}
