using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HC_QLDatVeXemPhim.Entities
{
    public class DatVe
    {
        [Key]
        public int MaDatVe { get; set; }

        [Required]
        public string SoDienThoai { get; set; }

        [ForeignKey(nameof(LichChieuPhim))]
        public int MaLichChieuPhim { get; set; }

        public LichChieuPhim LichChieuPhim { get; set; }

        public DateTime ThoiGianDat { get; set; }
    }
}
