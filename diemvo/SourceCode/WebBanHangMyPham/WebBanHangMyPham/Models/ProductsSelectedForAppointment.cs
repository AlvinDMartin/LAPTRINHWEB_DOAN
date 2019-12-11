using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHangMyPham.Models
{
    public class ProductsSelectedForAppointment
    {
        public ProductsSelectedForAppointment()
        {
            count = 1;
        }
        
        public int Id { get; set; }
        public string AppointmentId { get; set; }
        [ForeignKey("AppointmentId")]
        public virtual Appointments Appointments { get; set; }
        public int MenuItemId { get; set; }

        [NotMapped]
        [ForeignKey("MenuItemId")]
        public virtual MenuItem MenuItem  { get; set; }
        [Range(1,int.MaxValue, ErrorMessage="Please enter a value greater than or equal to {1}")]
        public int count { get; set; }
        
    }

}
