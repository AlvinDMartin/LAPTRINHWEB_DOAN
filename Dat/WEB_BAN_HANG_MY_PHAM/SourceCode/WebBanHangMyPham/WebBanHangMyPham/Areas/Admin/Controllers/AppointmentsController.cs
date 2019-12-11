using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebBanHangMyPham.Data;
using WebBanHangMyPham.Models.ViewModels;
using WebBanHangMyPham.Utility;

namespace WebBanHangMyPham.Areas.Admin.Controllers
{
    [Authorize(Roles = SD.AdminEndUser + "," + SD.SuperAdminEndUser)]
    [Area("Admin")]
    public class AppointmentsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AppointmentsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            System.Security.Claims.ClaimsPrincipal currentUser = this.User;
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            AppointmentsViewModel appointmentVM = new AppointmentsViewModel()
            {
                Appointments = new List<Models.Appointments>()
            };

            appointmentVM.Appointments = _db.Appointments.Include(a => a.NguoiBanHang).ToList();

            if (User.IsInRole(SD.AdminEndUser))
            {
                appointmentVM.Appointments = appointmentVM.Appointments.Where(a => a.NguoiBanHangId == claim.Value).ToList();
            }

            return View(appointmentVM);
        }
    }
}