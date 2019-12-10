using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHangMyPham.Models.ViewModels
{
    public class TTinAndLoaiSanPhamViewModels
    {
        public IEnumerable<ThongTinLoaiSanPham> LoaiSPList { get; set; }
        public ThongTinSanPham ThongTinSanPham { get; set; }
        public List<string> SanPhamList { get; set; }
        public string StatusMessage { get; set; }
    }
}
