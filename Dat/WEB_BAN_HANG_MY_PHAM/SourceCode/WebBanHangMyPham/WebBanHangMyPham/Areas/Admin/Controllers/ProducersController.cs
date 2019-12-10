using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebBanHangMyPham.Data;
using WebBanHangMyPham.Models;
using WebBanHangMyPham.Models.ViewModels;
using WebBanHangMyPham.Utility;

namespace WebBanHangMyPham.Areas.Admin.Controllers
{
    [Authorize(Roles = SD.SuperAdminEndUser)]
    [Area("Admin")]
    public class ProducersController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ProducersController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _db.ThongTinNhaSanXuat.ToListAsync());
        }

        //-----------------------------------------------CREATE--------------------------------------

        //GET Creat Acgtion Method
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(NhaSanXuat thongtinnhasanxuat)
        {
            if (ModelState.IsValid)
            {
                _db.ThongTinNhaSanXuat.Add(thongtinnhasanxuat);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(thongtinnhasanxuat);
        }

        //-----------------------------------------------EDIT--------------------------------------
        //GET - Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var thongtinnhasanxuat = await _db.ThongTinNhaSanXuat.FindAsync(id);
            if (thongtinnhasanxuat == null)
            {
                return NotFound();
            }

            return View(thongtinnhasanxuat);
        }
        //POST Edit action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(NhaSanXuat thongtinnhasanxuat)
        {
            if (ModelState.IsValid)
            {
                _db.Update(thongtinnhasanxuat);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(thongtinnhasanxuat);
        }
        //-----------------------------------------------CREATE--------------------------------------
        //GET - Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var nhasx = await _db.ThongTinNhaSanXuat.FindAsync(id);
            if (nhasx == null)
            {
                return NotFound();
            }

            return View(nhasx);
        }
        //POST Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteComfirmed(int? id)
        {
            var nhasx = await _db.ThongTinNhaSanXuat.FindAsync(id);
            if (nhasx == null)
            {
                return View();
            }
            _db.ThongTinNhaSanXuat.Remove(nhasx);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}