using System;


    internal class Program
    {
        static void Main(string[] args)
        {
        double radio, area;
        Console.WriteLine("Ingrese el radio del circulo: ");
        radio = double.Parse(Console.ReadLine());
        area = Math.PI * Math.Pow(radio, 2);
        Console.WriteLine("El area del circulo es: " + area);
        }
    }