using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
    [Authorize(Roles = SD.AdminEndUser + "," + SD.SuperAdminEndUser)]
    [Area("Admin")]
    public class AppointmentsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AppointmentsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index(string searchName=null, string searchEmail=null, string searchPhone=null,string searchDate=null)
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

            if (searchName != null)
            {
                appointmentVM.Appointments = appointmentVM.Appointments.Where(a => a.TenKhachHang.ToLower().Contains(searchName.ToLower())).ToList();
            }
            if (searchEmail != null)
            {
                appointmentVM.Appointments = appointmentVM.Appointments.Where(a => a.EmailKhachHang.ToLower().Contains(searchEmail.ToLower())).ToList();
            }
            if (searchPhone != null)
            {
                appointmentVM.Appointments = appointmentVM.Appointments.Where(a => a.SdtKhachHang.ToLower().Contains(searchPhone.ToLower())).ToList();
            }
            if (searchDate != null)
            {
                try
                {
                    DateTime appDate = Convert.ToDateTime(searchDate);
                    appointmentVM.Appointments = appointmentVM.Appointments.Where(a => a.NgayMuaHang.ToShortDateString().Equals(appDate.ToShortDateString())).ToList();
                }
                catch (Exception ex)
                {

                }
            }

            return View(appointmentVM);
        }
        
        public async Task<IActionResult> Edit(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }
            var sanhamList = (IEnumerable<ThongTinSanPham>)(from p in _db.ThongTinSanPham
                                                         join a in _db.ProductsSelectedForAppointment
                                                         on p.Id equals a.Id
                                                         where a.AppointmentId == id
                                                         select p).Include("SanPham");
            AppointmentDetailsViewModel objAppointmentVM = new AppointmentDetailsViewModel()
            {
                Appointment = _db.Appointments.Include(a => a.NguoiBanHang).Where(a => a.Id == id).FirstOrDefault(),
                NguoiBanHang = _db.ApplicationUser.ToList(),
                SanPham = sanhamList.ToList()
            };
            return View(objAppointmentVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, AppointmentDetailsViewModel objAppointmentVM)
        {
            if(!ModelState.IsValid)
            {
                objAppointmentVM.Appointment.NgayMuaHang = objAppointmentVM.Appointment.NgayMuaHang
                    .AddHours(objAppointmentVM.Appointment.GioMuaHang.Hour)
                    .AddMinutes(objAppointmentVM.Appointment.GioMuaHang.Minute);
                var appointmentFromDb = _db.Appointments.Where(a => a.Id == objAppointmentVM.Appointment.Id).FirstOrDefault();

                appointmentFromDb.TenKhachHang = objAppointmentVM.Appointment.TenKhachHang;
                appointmentFromDb.EmailKhachHang = objAppointmentVM.Appointment.EmailKhachHang;
                appointmentFromDb.SdtKhachHang = objAppointmentVM.Appointment.SdtKhachHang;
                appointmentFromDb.NgayMuaHang = objAppointmentVM.Appointment.NgayMuaHang;
                appointmentFromDb.XacNhan = objAppointmentVM.Appointment.XacNhan;

                if(User.IsInRole(SD.SuperAdminEndUser))
                {
                    appointmentFromDb.NguoiBanHangId = objAppointmentVM.Appointment.NguoiBanHangId;
                }
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(objAppointmentVM);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var sanhamList = (IEnumerable<ThongTinSanPham>)(from p in _db.ThongTinSanPham
                                                            join a in _db.ProductsSelectedForAppointment
                                                            on p.Id equals a.Id
                                                            where a.AppointmentId == id
                                                            select p).Include("SanPham");
            AppointmentDetailsViewModel objAppointmentVM = new AppointmentDetailsViewModel()
            {
                Appointment = _db.Appointments.Include(a => a.NguoiBanHang).Where(a => a.Id == id).FirstOrDefault(),
                NguoiBanHang = _db.ApplicationUser.ToList(),
                SanPham = sanhamList.ToList()
            };
            return View(objAppointmentVM);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var sanhamList = (IEnumerable<ThongTinSanPham>)(from p in _db.ThongTinSanPham
                                                            join a in _db.ProductsSelectedForAppointment
                                                            on p.Id equals a.Id
                                                            where a.AppointmentId == id
                                                            select p).Include("SanPham");
            AppointmentDetailsViewModel objAppointmentVM = new AppointmentDetailsViewModel()
            {
                Appointment = _db.Appointments.Include(a => a.NguoiBanHang).Where(a => a.Id == id).FirstOrDefault(),
                NguoiBanHang = _db.ApplicationUser.ToList(),
                SanPham = sanhamList.ToList()
            };
            return View(objAppointmentVM);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfimed(int id)
        {
            var appointment = await _db.Appointments.FindAsync(id);
            _db.Appointments.Remove(appointment);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}