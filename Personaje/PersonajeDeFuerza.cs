using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personaje
{
    internal class PersonajeDeFuerza : Personaje
    {
        public PersonajeDeFuerza(string nombre,int agilidad, int magia)
        { 
        Nombre = nombre;
        Fuerza = 100;
        Agilidad = agilidad;
        Magia = magia;
    }

        public override int CalcularDanio()
        {
            return (Magia * Agilidad + Fuerza);
        }

        public override int MoverseEjeX()
        {
            return 2;
        }
        public override int MoverseEjeY()
        {
            return 2;
        }
    }
