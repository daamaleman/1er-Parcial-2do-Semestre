using System;

    internal class Program
    {
        static void Main(string[] args)
        {
        string nombre;
        string cargo;
        double salario;
        double aumento;

        Console.WriteLine("Ingrese el nombre del empleado: ");
        nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el cargo del empleado: ");
        cargo = Console.ReadLine();
        Console.WriteLine("Ingrese el salario del empleado: ");
        salario = double.Parse(Console.ReadLine());
        aumento = salario * 0.25;
        Console.WriteLine();
        Console.WriteLine("Datos del empleado:");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Cargo: " + cargo);
        Console.WriteLine("Salario: " + salario);
        Console.WriteLine("Aumento del 25%: " + aumento);
        Console.WriteLine("Salario con aumento: " + (salario + aumento));
        }
    }