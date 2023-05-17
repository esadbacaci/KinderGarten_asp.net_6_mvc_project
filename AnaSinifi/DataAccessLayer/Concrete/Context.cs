using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;database=anasinifi;user=root;password=esad2074",
                new MySqlServerVersion(new Version(8, 0, 23)));
            }

        }
		public DbSet<Admin>? Admins { get; set; }
		public DbSet<Egitmenler>? Egitmenlers { get; set; }
		public DbSet<Ders>? Dersler { get; set; }
		public DbSet<Duyurular>? Duyurulars { get; set; }
		public DbSet<Hakkimizda>? Hakkimizdas { get; set; }
		public DbSet<KayitForm>? KayitForms { get; set; }
		public DbSet<Slider>? Sliders { get; set; }
		public DbSet<Galeri>? Galeris { get; set; }
		public DbSet<YtLink>? YtLinks { get; set; }
	}
}

