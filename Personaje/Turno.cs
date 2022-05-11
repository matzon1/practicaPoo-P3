using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personaje
{
    public class Turno
    {
        public static void Atacarse(IList<Personaje> personajes)
        {
            foreach (var person in personajes)
            {
                person.Atacar();
            }
        }

        public static void MoverFichas(IMoverse ficha)
        {
            ficha.MoverseEjeX();
            ficha.MoverseEjeY();
        }
    }
}
