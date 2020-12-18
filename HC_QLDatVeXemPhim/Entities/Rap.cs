﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HC_QLDatVeXemPhim.Entities
{
    public class Rap
    {
        [Key]
        public int MaRap { get; set; }

        public string TenRap { get; set; }

        public int SoChoTrong { get; set; }
        
        public ICollection<LichChieuPhim> LichChieuPhims { get; set; }
    }
}