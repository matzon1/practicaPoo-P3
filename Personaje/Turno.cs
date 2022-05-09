using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personaje
{
    internal class Turno
    {
        public static void Atacarse(IList<Personaje> personajes)
        {
            return personajes.Select(x => x.Atacar(y, y)).ToList();
        }

        public static void MoverFichas(IMoverse ficha)
        {

        }
    }
}
