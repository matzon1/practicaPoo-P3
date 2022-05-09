using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personaje
{
    internal class PersonajeDeAgilidad : Personaje
    {
        public PersonajeDeAgilidad(string nombre, int fuerza, int agilidad, int magia)
        {
            Nombre = nombre;
            Fuerza = fuerza;
            Agilidad = agilidad;
            Magia = magia;
        }

        public override int CalcularDanio()
        {
            return ((Fuerza / 2) * ((Agilidad * Magia) / 2));
        }

        public override string Atacar(string nombre, int danio)
        {
            return base.Atacar(nombre, CalcularDanio());
        }

        public override int MoverseEjeX()
        {
            return 7;
        }
        public override int MoverseEjeY()
        {
            return 7;
        }
    }
}
