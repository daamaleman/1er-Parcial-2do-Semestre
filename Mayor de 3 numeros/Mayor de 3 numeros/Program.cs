using System;


    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            Console.WriteLine("Ingrese el primer número");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"El numero {num1} es el mayor");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"El numero {num2} es el mayor");
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine($"El numero {num3} es el mayor");
            }
            else
            {
                Console.WriteLine("Los números son iguales");
        }

    }
}