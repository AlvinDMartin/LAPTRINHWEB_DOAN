﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHangMyPham.Models.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<MenuItem> MenuItem { get; set; }
        public IEnumerable<ThongTinLoaiSanPham> ThongTinLoaiSanPham { get; set; }
        public IEnumerable<Coupon> Coupon { get; set; }

    }
}
