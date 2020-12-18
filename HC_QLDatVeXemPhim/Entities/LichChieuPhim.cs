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
        public int MaLichChieuPhim { get; set; }

        [ForeignKey(nameof(Rap))]
        public int MaRap { get; set; }

        public Rap Rap { get; set; }

        [ForeignKey(nameof(Phim))]
        public int MaPhim { get; set; }

        public Phim Phim { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ThoiGianChieu { get; set; }

        public ICollection<DatVe> DatVes { get; set; }
    }
}
