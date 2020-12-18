using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HC_QLDatVeXemPhim.Entities
{
    public class LichChieuPhim
    {
        [Key]
        [ForeignKey(nameof(Rap))]
        public int MaRap { get; set; }

        public Rap Rap { get; set; }

        [Key]
        [ForeignKey(nameof(Phim))]
        public int MaPhim { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ThoiGianChieu { get; set; }
    }
}
