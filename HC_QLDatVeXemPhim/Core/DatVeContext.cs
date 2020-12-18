using HC_QLDatVeXemPhim.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HC_QLDatVeXemPhim.Core
{
    public class DatVeContext : DbContext
    {
        public DbSet<Rap> Raps { get; set; }

        public DbSet<LichChieuPhim> LichChieuPhims { get; set; }

        public DbSet<Phim> Phims { get; set; }

        public DbSet<DatVe> DatVes { get; set; }

        public DatVeContext(DbContextOptions options): base(options)
        { }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<DatVe>(o =>
            {
                o.Property(x => x.ThoiGianDat).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
        }
    }
}
