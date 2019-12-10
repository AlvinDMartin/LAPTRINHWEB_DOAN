using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebBanHangMyPham.Data;
using WebBanHangMyPham.Models;
using WebBanHangMyPham.Models.ViewModels;
using WebBanHangMyPham.Utility;

namespace WebBanHangMyPham.Areas.Admin.Controllers
{
    [Authorize(Roles = SD.SuperAdminEndUser)]
    [Area("Admin")]
    public class ThongTinSanPhamController : Controller
    {
        private readonly ApplicationDbContext _db;

        public string StatusMessage { get; private set; }

        public ThongTinSanPhamController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _db.ThongTinSanPham.Include(s=>s.ThongTinLoaiSanPham).ToListAsync());
        }

//-----------------------------------------------CREATE--------------------------------------

        //GET Create Action Method
        public async Task<IActionResult> Create()
        {
            TTinAndLoaiSanPhamViewModels model = new TTinAndLoaiSanPhamViewModels()
            {
                LoaiSPList = await _db.ThongTinLoaiSanPham.ToListAsync(),
                ThongTinSanPham = new Models.ThongTinSanPham(),
                SanPhamList = await _db.ThongTinSanPham.OrderBy(p => p.TenSanPham).Select(p => p.TenSanPham).Distinct().ToListAsync()
            };

            return View(model);
        }
        //POST - CREATE
        //POST Create action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TTinAndLoaiSanPhamViewModels model)
        {
            if (ModelState.IsValid)
            {
                var doesThongTinSanPhamExists = _db.ThongTinSanPham.Include(s => s.ThongTinLoaiSanPham).Where(s => s.TenSanPham == model.ThongTinSanPham.TenSanPham && s.ThongTinLoaiSanPham.Id == model.ThongTinSanPham.LoaiSanPhamId);

                if (doesThongTinSanPhamExists.Count() > 0)
                {
                    //Error
                    StatusMessage = "Error : Thông tin sản phẩm exists under " + doesThongTinSanPhamExists.First().ThongTinLoaiSanPham.TenLoaiSanPham + "Thông tin loại sản phẩm. Please use another name.";
                }
                else
                {
                    _db.ThongTinSanPham.Add(model.ThongTinSanPham);
                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            TTinAndLoaiSanPhamViewModels modelVM = new TTinAndLoaiSanPhamViewModels()
            {
                LoaiSPList = await _db.ThongTinLoaiSanPham.ToListAsync(),
                ThongTinSanPham = model.ThongTinSanPham,
                SanPhamList = await _db.ThongTinSanPham.OrderBy(p => p.TenSanPham).Select(p => p.TenSanPham).ToListAsync(),
                StatusMessage = StatusMessage
            };
            return View(modelVM);
        }

        [ActionName("GetThongTinSanPham")]
        public async Task<IActionResult> GetThongTinSanPham(int id)
        {
            List<ThongTinSanPham> thongTinSanPhams = new List<ThongTinSanPham>();

            thongTinSanPhams = await (from thongTinSanPham in _db.ThongTinSanPham
                                      where thongTinSanPham.LoaiSanPhamId == id
                                      select thongTinSanPham).ToListAsync();
            return Json(new SelectList(thongTinSanPhams, "Id", "TenLoaiSanPham"));
        }
    }
}