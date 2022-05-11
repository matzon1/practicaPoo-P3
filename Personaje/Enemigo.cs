using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personaje
{
    public class Enemigo : IMoverse
    {
        public string? Nombre;
        public int Vida;
        public int Nivel;


        public Enemigo(string nombre, int vida, int nivel)
        {
            Nombre = nombre;
            Vida = vida;
            Nivel = nivel;
        }

        public int MoverseEjeX()
        {
            return 2;
        }

        public int MoverseEjeY()
        {
            return 9;
        }
    }
}
