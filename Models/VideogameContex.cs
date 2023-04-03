using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace net_ef_videogame.Models
{
    public class VideogameContex : DbContext
    {
        public DbSet<Videogame> Videogames { get; set; }
        public DbSet<SoftwareHouse> SoftwareHouses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=localhost;Initial Catalog=EF_videogame_db;Integrated Security=True;Pooling=False;TrustServerCertificate=True");
        }
    }
}
