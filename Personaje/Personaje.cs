using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personaje
{
    public abstract class Personaje : IMoverse
    {
        public string? Nombre { get; set; }
        public int Fuerza { get; set; }
        public int Agilidad { get; set; }
        public int Magia { get; set; }


        public abstract int CalcularDanio();

        public virtual string Atacar(string nombre, int danio)
        {
            return $"{nombre} hizo {danio} de daño";
        }

        public abstract int MoverseEjeX();
        public abstract int MoverseEjeY();
    }
}
