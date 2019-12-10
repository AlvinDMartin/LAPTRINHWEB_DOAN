using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebBanHangMyPham.Data;
using WebBanHangMyPham.Models.ViewModels;
using WebBanHangMyPham.Extensions;
using Microsoft.AspNetCore.Http;
using WebBanHangMyPham.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using WebBanHangMyPham.Utility;

namespace WebBanHangMyPham.Areas.Customer.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public ShippingCartViewModel ShopppingCartVM { get; set; }
        public ShoppingCartController(ApplicationDbContext db)
        {
            _db = db;
            ShopppingCartVM = new ShippingCartViewModel()
            {
                MenuItems = new List<Models.MenuItem>()
            };
        }

        //Nhận số giỏ hàng
        public async Task<IActionResult> Index()
        {
            List<int> lstShoppingCart = HttpContext.Session.Get<List<int>>("ssShopppingCart");
            if (lstShoppingCart.Count > 0)
            {
                foreach (int cartItem in lstShoppingCart)
                {
                    MenuItem thongTinSanPham = _db.MenuItem.Include(p => p.Name).Include(p => p.ThongTinLoaiSanPham).Where(p => p.Id == cartItem).FirstOrDefault();
                    ShopppingCartVM.MenuItems.Add(thongTinSanPham);
                }
            }
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            if (claim != null)
            {
                var cnt = _db.ProductsSelectedForAppointment.Where(u => u.AppointmentId == claim.Value).ToList().Count;
                HttpContext.Session.SetInt32(SD.ssShoppingCartCount, cnt);
            }
            return View(ShopppingCartVM);
        }

        
        public async Task<IActionResult> Details(int id)
        {
            var menuItemFromDb = await _db.MenuItem.Include(m => m.ThongTinLoaiSanPham).Include(m => m.ThongTinSanPham).Where(m => m.Id == id).FirstOrDefaultAsync();
            ProductsSelectedForAppointment cartObj = new ProductsSelectedForAppointment()
            {
                MenuItem = menuItemFromDb,
                MenuItemId = menuItemFromDb.Id
            
            };
            return View(cartObj);
        }
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details(ProductsSelectedForAppointment CartObject)
        {
            CartObject.Id = 0;
            if(ModelState.IsValid)
            {
                var claimsIdentity = (ClaimsIdentity)this.User.Identity;
                var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
                CartObject.AppointmentId = claim.Value;

                ProductsSelectedForAppointment cartFromDb = await _db.ProductsSelectedForAppointment.Where(c=>c.AppointmentId == CartObject.AppointmentId 
                                                                    && c.MenuItemId == CartObject.MenuItemId).FirstOrDefaultAsync();

                if(cartFromDb==null)
                {
                    await _db.ProductsSelectedForAppointment.AddAsync(CartObject);
                }
                else
                {
                    cartFromDb.count = cartFromDb.count + CartObject.count;
                }
                await _db.SaveChangesAsync();

                var count = _db.ProductsSelectedForAppointment.Where(c => c.AppointmentId == CartObject.AppointmentId).ToList().Count();
                HttpContext.Session.SetInt32(SD.ssShoppingCartCount, count);
                return RedirectToAction("Index");

            }
            else
            {
                var menuItemFromDb = await _db.MenuItem.Include(m => m.ThongTinLoaiSanPham).Include(m => m.ThongTinSanPham).Where(m => m.Id == CartObject.MenuItemId).FirstOrDefaultAsync();
                ProductsSelectedForAppointment cartObj = new ProductsSelectedForAppointment()
                {
                    MenuItem = menuItemFromDb,
                    MenuItemId = menuItemFromDb.Id

                };
                return View(cartObj);
            }
        }


    }
}

