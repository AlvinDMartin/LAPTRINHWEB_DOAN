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
                ThongTinSanPhams = new List<Models.ThongTinSanPham>()
            };
        }

        //Nhận số giỏ hàng
        public async Task<IActionResult> Index()
        {
            List<int> lstShoppingCart = HttpContext.Session.Get<List<int>>("ssShopppingCart");
            if(lstShoppingCart.Count>0)
            {
                foreach(int cartItem in lstShoppingCart)
                {
                    ThongTinSanPham thongTinSanPham = _db.ThongTinSanPham.Include(p => p.HangSanXuat).Include(p => p.ThongTinLoaiSanPham).Where(p => p.Id == cartItem).FirstOrDefault();
                    ShopppingCartVM.ThongTinSanPhams.Add(thongTinSanPham);
                }
            }

            return View(ShopppingCartVM);
        }
    }
}
