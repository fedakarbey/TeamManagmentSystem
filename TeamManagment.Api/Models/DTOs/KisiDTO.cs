﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagment.Api.Models.DTOs
{
    public class KisiDTO
    {
        public int KisiID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int? UnvanID { get; set; }
    }
}
