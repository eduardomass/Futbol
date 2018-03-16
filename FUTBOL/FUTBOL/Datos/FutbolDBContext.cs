using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FUTBOL.Datos
{
    public class FutbolDBContext : DbContext
    {
        public DbSet<Jugador> Juadores { get; set; }
    }
}