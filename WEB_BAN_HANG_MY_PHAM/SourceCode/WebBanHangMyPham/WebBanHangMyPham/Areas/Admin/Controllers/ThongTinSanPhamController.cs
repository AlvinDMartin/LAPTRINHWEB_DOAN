using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebBanHangMyPham.Data;
using WebBanHangMyPham.Models;
using WebBanHangMyPham.Models.ViewModels;

namespace WebBanHangMyPham.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ThongTinSanPhamController : Controller
    {
        private readonly ApplicationDbContext _db;

        [TempData]
        public string StatusMessage { get; set; }

        public ThongTinSanPhamController(ApplicationDbContext db)
        {
            _db = db;
        }
        //Get INDEX
        public async Task<IActionResult> Index()
        {
            var thongtinsanphams = await _db.ThongTinSanPham.Include(s => s.ThongTinLoaiSanPham).ToListAsync();
            return View(thongtinsanphams);
        }

//-----------------------------------------------CREATE---------------------------------------------

        //GET Create Action Method
        public async Task<IActionResult> Create()
        {
            TTinAndLoaiSanPhamViewModels model = new TTinAndLoaiSanPhamViewModels()
            {
                LoaiSPList = await _db.ThongTinLoaiSanPham.ToListAsync(),
                ThongTinSanPham = new Models.ThongTinSanPham(),
                SanPhamList = await _db.ThongTinSanPham.OrderBy(p => p.TenSanPham).Select(p => p.TenSanPham).Distinct().ToListAsync(),
                DonGiaSanPhamList = await _db.ThongTinSanPham.OrderBy(p => p.DonGia).Select(p => p.DonGia).Distinct().ToListAsync(),
                HangSanPhamList = await _db.ThongTinSanPham.OrderBy(p => p.HangSanXuat).Select(p => p.HangSanXuat).Distinct().ToListAsync()

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
                DonGiaSanPhamList = await _db.ThongTinSanPham.OrderBy(p => p.DonGia).Select(p => p.DonGia).Distinct().ToListAsync(),
                HangSanPhamList = await _db.ThongTinSanPham.OrderBy(p => p.HangSanXuat).Select(p => p.HangSanXuat).Distinct().ToListAsync(),
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



//-----------------------------------------------Edit----------------------------------------

        //GET Edit
        public async Task<IActionResult> Edit( int ? id)
        {
            if(id ==null)
            {
                return NotFound();
            }

            var thongtinsanpham = await _db.ThongTinSanPham.SingleOrDefaultAsync(m => m.Id == id);

            if(thongtinsanpham == null)
            {
                return NotFound();

            }

            TTinAndLoaiSanPhamViewModels model = new TTinAndLoaiSanPhamViewModels()
            {
                LoaiSPList = await _db.ThongTinLoaiSanPham.ToListAsync(),
                ThongTinSanPham = thongtinsanpham,
                SanPhamList = await _db.ThongTinSanPham.OrderBy(p => p.TenSanPham).Select(p => p.TenSanPham).Distinct().ToListAsync(),
                DonGiaSanPhamList = await _db.ThongTinSanPham.OrderBy(p => p.DonGia).Select(p => p.DonGia).Distinct().ToListAsync(),
                HangSanPhamList = await _db.ThongTinSanPham.OrderBy(p => p.HangSanXuat).Select(p => p.HangSanXuat).Distinct().ToListAsync()

            };

            return View(model);
        }
        //POST - edit
        //POST Create action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TTinAndLoaiSanPhamViewModels model)
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
                DonGiaSanPhamList = await _db.ThongTinSanPham.OrderBy(p => p.DonGia).Select(p => p.DonGia).Distinct().ToListAsync(),
                HangSanPhamList = await _db.ThongTinSanPham.OrderBy(p => p.HangSanXuat).Select(p => p.HangSanXuat).Distinct().ToListAsync(),
                StatusMessage = StatusMessage
            };
            return View(modelVM);
        }


    }
}