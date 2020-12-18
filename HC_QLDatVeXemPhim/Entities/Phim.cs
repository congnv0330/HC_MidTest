using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HC_QLDatVeXemPhim.Entities
{
    public class Phim
    {
        [Key]
        public int MaPhim { get; set; }

        [Required]
        public string TenPhim { get; set; }

        public int ThoiLuong { get; set; }

        public ICollection<LichChieuPhim> LichChieuPhims { get; set; }
    }
}
