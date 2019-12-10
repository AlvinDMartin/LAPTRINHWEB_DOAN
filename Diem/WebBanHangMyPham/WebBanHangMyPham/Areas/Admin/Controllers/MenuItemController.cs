using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebBanHangMyPham.Data;
using WebBanHangMyPham.Models.ViewModels;
using WebBanHangMyPham.Utility;

namespace WebBanHangMyPham.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class MenuItemController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _webHostEnvironment;

        [BindProperty]
        public MenuItemViewModel MenuItemVM { get; set; }
        public string SanPhamId { get; private set; }

        public MenuItemController(ApplicationDbContext db, IWebHostEnvironment webHostEnvironment)
        {
            _db = db;
            _webHostEnvironment = webHostEnvironment;
            MenuItemVM = new MenuItemViewModel()
            {
                ThongTinLoaiSanPham = _db.ThongTinLoaiSanPham,
                MenuItem = new Models.MenuItem()
            };
        }

        public async Task<IActionResult> Index()
        {
            var menuItems = await _db.MenuItem.Include(m => m.ThongTinLoaiSanPham).Include(m=>m.ThongTinSanPham).ToListAsync();
            return View(menuItems);
        }

        //GET - CREATE
        public IActionResult Create()
        {
            return View(MenuItemVM);
        }

        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePOST()
        {
            MenuItemVM.MenuItem.SanPhamId = Convert.ToInt32(Request.Form[SanPhamId].ToString());
            if (!ModelState.IsValid)
            {
                return View(MenuItemVM);
            }
            _db.MenuItem.Add(MenuItemVM.MenuItem);
            await _db.SaveChangesAsync();

            //work on the image saving section
            string webRootPath = _webHostEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;

            var menuItemFromDb = await _db.MenuItem.FindAsync(MenuItemVM.MenuItem.Id);

            if (files.Count > 0)
            {
                //New image has been uploaded
                var uploads = Path.Combine(webRootPath, "images");
                var extension = Path.GetExtension(files[0].FileName);


                //We will upload the new file
                using (var filesStream = new FileStream(Path.Combine(uploads, MenuItemVM.MenuItem.Id + extension), FileMode.Create))
                {
                    files[0].CopyTo(filesStream);
                }
                menuItemFromDb.Image = @"\images\" + MenuItemVM.MenuItem.Id + extension;
            }
            else
            {
                //no file was uploaded, so use default
                var uploads = Path.Combine(webRootPath, @"\images\" + SD.DefaultSkincareImage);
                System.IO.File.Copy(uploads, webRootPath + @"\images\" + MenuItemVM.MenuItem.Id + ".png");
                menuItemFromDb.Image = @"\images\" + MenuItemVM.MenuItem.Id + ".png";
            }
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        //GET - EDIT
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            MenuItemVM.MenuItem = await _db.MenuItem.Include(m => m.ThongTinLoaiSanPham).Include(m => m.ThongTinSanPham).SingleOrDefaultAsync(m => m.Id == id);
            MenuItemVM.ThongTinSanPham = await _db.ThongTinSanPham.Where(s => s.LoaiSanPhamId == MenuItemVM.MenuItem.LoaiSanPhamId).ToListAsync();

            if (MenuItemVM.MenuItem==null)
            {
                return NotFound();
            }
            return View(MenuItemVM);
        }

        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPOST(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            MenuItemVM.MenuItem.SanPhamId = Convert.ToInt32(Request.Form[SanPhamId].ToString());
            if (!ModelState.IsValid)
            {
                MenuItemVM.ThongTinSanPham = await _db.ThongTinSanPham.Where(s => s.LoaiSanPhamId == MenuItemVM.MenuItem.LoaiSanPhamId).ToListAsync();
                return View(MenuItemVM);
            }
            //work on the image saving section
            string webRootPath = _webHostEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;

            var menuItemFromDb = await _db.MenuItem.FindAsync(MenuItemVM.MenuItem.Id);

            if (files.Count > 0)
            {
                //New Image has been uploaded
                var uploads = Path.Combine(webRootPath, "images");
                var extension_new = Path.GetExtension(files[0].FileName);

                //Delete original file
                var imagePath = Path.Combine(webRootPath, menuItemFromDb.Image.TrimStart('\\'));
                if (System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                }

                using (var filesStream = new FileStream(Path.Combine(uploads, MenuItemVM.MenuItem.Id + extension_new), FileMode.Create))
                {
                    files[0].CopyTo(filesStream);
                }
                menuItemFromDb.Image = @"\images\" + MenuItemVM.MenuItem.Id + extension_new;
            }
            menuItemFromDb.Name = MenuItemVM.MenuItem.Name;
            menuItemFromDb.MoTa = MenuItemVM.MenuItem.MoTa;
            menuItemFromDb.Price = MenuItemVM.MenuItem.Price;
            menuItemFromDb.LoaiSanPhamId = MenuItemVM.MenuItem.LoaiSanPhamId;
            menuItemFromDb.SanPhamId = MenuItemVM.MenuItem.SanPhamId;

            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}