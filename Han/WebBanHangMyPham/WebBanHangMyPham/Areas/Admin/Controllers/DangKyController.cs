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
    public class DangKyController : Controller
    {

        private readonly ApplicationDbContext _db;

        public DangKyController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _db.DangKy.ToListAsync());
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
        public async Task<IActionResult> Create(DangKy dangKy)
        {
            if (ModelState.IsValid)
            {
                _db.DangKy.Add(dangKy);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dangKy);
        }

//-----------------------------------------------EDIT--------------------------------------
        //GET - Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var dangKy = await _db.DangKy.FindAsync(id);
            if (dangKy == null)
            {
                return NotFound();
            }

            return View(dangKy);
        }

        //POST Edit action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(DangKy dangky)
        {
            if (ModelState.IsValid)
            {
                _db.Update(dangky);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(dangky);
        }

//-----------------------------------------------CREATE--------------------------------------
        //GET - Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var makhachhang = await _db.DangKy.FindAsync(id);
            if (makhachhang == null)
            {
                return NotFound();
            }

            return View(makhachhang);
        }
        //POST Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteComfirmed(int? id)
        {
            var makhachhang = await _db.DangKy.FindAsync(id);
            if (makhachhang == null)
            {
                return View();
            }
            _db.DangKy.Remove(makhachhang);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

//-----------------------------------------------Details--------------------------------------
        //GET - Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var dangKy = await _db.DangKy.FindAsync(id);
            if (dangKy == null)
            {
                return NotFound();
            }

            return View(dangKy);
        }

        //POST Details action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details(DangKy dangky)
        {
            if (ModelState.IsValid)
            {
                _db.Update(dangky);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(dangky);
        }
    }
}