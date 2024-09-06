using System.Globalization;
using Uso_if.models;

namespace Uso_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Decir si es ninho, joven o adulto
            //Ninho 0 - 12
            //Joven 13 - 25
            //Adulto 26 a mas

            int edad = 0;
            Evaluate evaluate = new Evaluate();
            Console.WriteLine("Evaluar edad");
            Console.WriteLine("Ingresa tu edad: ");
            try
            {
                edad = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Tostring());
            }

            Console.WriteLine(evaluate.EvalAge(edad));
        }
    }
}
