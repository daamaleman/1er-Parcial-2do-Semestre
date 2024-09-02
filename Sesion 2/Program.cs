using System.Globalization;
using Sesion_2.clases;

namespace Sesion_2
{
    // Leer los datos de una persona y decir si es mayor o menos de edad
    internal class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            DateTime fechaNac;
            Persona personas = new Persona();

            Console.Write("Dime tu nombre: ");
            nombre = Console.ReadLine();
            Console.Write("En que fecha naciste?: ");
            fechaNac = DateTime.Parse(Console.ReadLine());

            personas.Nombre = nombre;
            personas.FechaNac = fechaNac;

            Console.WriteLine(personas.EvaluarEdad());
        }
    }
}