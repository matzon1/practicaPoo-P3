using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personaje
{
    public class PersonajeDeMagia : Personaje
    {
        public PersonajeDeMagia(string nombre, int fuerza, int agilidad, int magia)
        {
            Nombre = nombre;
            Fuerza = fuerza;
            Agilidad = agilidad;
            Magia = magia;
        }

        public PersonajeDeMagia(string nombre, int fuerza, int agilidad)
        {
            Nombre = nombre;
            Fuerza = fuerza;
            Agilidad = agilidad;
            Magia = 60;
        }

        public override int CalcularDanio()
        {
            return (Fuerza + Agilidad + Magia) * 4;
        }


        public override int MoverseEjeX()
        {
            return 5;
        }
        public override int MoverseEjeY()
        {
            return 5;
        }
    }
}
