using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class BiletContext: DbContext
    {
        public DbSet<Bilet> Bilets { get; set; }
        public DbSet<Guzergah> Guzergahs { get; set; }
        public DbSet<Sehir> Sehirs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-R3GLQE7;Database = DbHizliBilet;Integrated Security = True;");
        }
    }
}
