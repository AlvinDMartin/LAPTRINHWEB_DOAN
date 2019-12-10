using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebBanHangMyPham.Data;

namespace WebBanHangMyPham.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class AddSanPhamController : Controller
    {
        private readonly ApplicationDbContext _db;


        public AddSanPhamController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            var thongtinsanphams = await _db.ThongTinSanPham.Include(s => s.ThongTinLoaiSanPham).ToListAsync();
            return View(thongtinsanphams);
        }
    }
}