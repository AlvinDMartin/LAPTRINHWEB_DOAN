using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebBanHangMyPham.Data;
using WebBanHangMyPham.Models;

namespace WebBanHangMyPham.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoaiSanPhamController : Controller
    {

        private readonly ApplicationDbContext _db;

        public LoaiSanPhamController (ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _db.ThongTinLoaiSanPham.ToListAsync());
        }

        //-----------------------------------------------CREATE--------------------------------------

        //GET Creat Acgtion Method
        public IActionResult Create()
        {
            return View();
        }

        //POST Create action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ThongTinLoaiSanPham thongTinLoaiSanPham)
        {
            if (ModelState.IsValid)
            {
                _db.ThongTinLoaiSanPham.Add(thongTinLoaiSanPham);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(thongTinLoaiSanPham);
        }

        //-----------------------------------------------EDIT--------------------------------------
        //GET - Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var thongTinLoaiSanPham = await _db.ThongTinLoaiSanPham.FindAsync(id);
            if (thongTinLoaiSanPham == null)
            {
                return NotFound();
            }

            return View(thongTinLoaiSanPham);
        }

        //POST Edit action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ThongTinLoaiSanPham thongTinLoaiSanPham)
        {
            if (ModelState.IsValid)
            {
                _db.Update(thongTinLoaiSanPham);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(thongTinLoaiSanPham);
        }

        //-----------------------------------------------CREATE--------------------------------------
        //GET - Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var loaisp = await _db.ThongTinLoaiSanPham.FindAsync(id);
            if (loaisp == null)
            {
                return NotFound();
            }

            return View(loaisp);
        }
        //POST Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteComfirmed(int? id)
        {
            var loaisp = await _db.ThongTinLoaiSanPham.FindAsync(id);
            if (loaisp == null)
            {
                return View();
            }
            _db.ThongTinLoaiSanPham.Remove(loaisp);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
    

}