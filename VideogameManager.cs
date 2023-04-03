using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core;
using Microsoft.EntityFrameworkCore;
using net_ef_videogame.Models;

namespace net_ef_videogame
{
    public class VideogameManager
    {
        public static void Insert(Videogame videogame)
        {
            using var db = new VideogameContex(); 
            db.Videogames.Add(videogame);
            db.SaveChanges();
        }

        public Videogame? SearchById(long id)
        {
            using var db = new VideogameContex();
            return db.Videogames.Find(id);
        }

        public IEnumerable<Videogame> SearchByName(string nome)
        {
            using var db = new VideogameContex();
            return db.Videogames.Where(v => v.Name.Contains(nome));
        }

        public void Delete(long id)
        {
            using var db = new VideogameContex();
            var vg = db.Videogames.Find(id);

            if (vg != null) return;
            db.Videogames.Remove(vg); 
            db.SaveChanges();
        }

        public static void InsertSoftwareHouse(SoftwareHouse softwareHouse)
        {
            using var db = new VideogameContex();

            db.SoftwareHouses.Add(softwareHouse);
            db.SaveChanges();
        }

    }
}
