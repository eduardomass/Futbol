using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FUTBOL.Datos
{
    public class ADJugador
    {

        FutbolDBContext dbContext;

        public List<Jugador> Buscar()
        {
            
            return dbContext.Juadores.ToList();
        }

        public ADJugador()
        {
            this.dbContext = new FutbolDBContext();
        }
        //Transaccional
        public ADJugador(FutbolDBContext dbContextTransaccional)
        {
            this.dbContext = dbContextTransaccional;
        }

        public void Agregar(Jugador jugador)
        {
            dbContext.Juadores.Add(jugador);
            dbContext.SaveChanges();
        }
        //Transaccional
        public void Agregar(Jugador jugador, FutbolDBContext dbContext)
        {
            dbContext.Juadores.Add(jugador);
        }
    }
}