namespace Personaje
{
    public class Program
    {
        public static void Main()
        {
            List<Personaje> personajes = new List<Personaje>();
            personajes.Add(new PersonajeDeFuerza("Trundle", 20, 40));
            personajes.Add(new PersonajeDeAgilidad("Wukong", 70, 30, 21));
            personajes.Add(new PersonajeDeMagia("Malzahar", 60, 40, 20));
            personajes.Add(new PersonajeDeFuerza("Garen", 90, 22));

            Console.WriteLine("Heroes:");

            foreach (var person in personajes)
            {
                Console.WriteLine($"Nombre: {person.Nombre} - Fuerza: {person.Fuerza} - Agilidad: {person.Agilidad} - Magia: {person.Magia}");
            }


            List<Enemigo> enem = new List<Enemigo>();
            enem.Add(new Enemigo("Fizz", 20, 40));
            enem.Add(new Enemigo("KaiSa", 50, 55));

            Console.WriteLine("Enemigos:");

            foreach (var enemigo in enem)
            {
                Console.WriteLine($"Nombre: {enemigo.Nombre} - Vida: {enemigo.Vida} - Nivel: {enemigo.Nivel}");
            }

            Console.WriteLine("Acciones:");

            Turno.Atacarse(personajes);
            Turno.MoverFichas(personajes[1]);
            Turno.MoverFichas(enem[1]);
        }
    }
}
