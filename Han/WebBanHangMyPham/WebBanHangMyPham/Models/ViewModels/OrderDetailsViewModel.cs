﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHangMyPham.Models.ViewModels
{
    public class OrderDetailsViewModel
    {
        public List<ProductsSelectedForAppointment> { get; set; }
        public OrderHeader OrderHeader { get; set; }
        
    }
}
