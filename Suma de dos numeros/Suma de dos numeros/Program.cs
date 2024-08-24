using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int num1;
        int num2;
        int suma;
        Console.WriteLine("Introduce el primer número: ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduce el segundo número: ");
        num2 = int.Parse(Console.ReadLine());
        suma = num1 + num2;
        Console.WriteLine($"La suma de {num1} y {num2} es {suma}");
    }
}
