using System;

namespace uri1018 // Cédulas
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int valor);
            int cedula, resto;

            Console.WriteLine(valor);
            cedula = valor / 100;
            resto = valor % 100;
            Console.WriteLine($"{cedula} nota(s) de R$ 100,00");
            cedula = resto / 50;
            resto %= 50;
            Console.WriteLine($"{cedula} nota(s) de R$ 50,00");
            cedula = resto / 20;
            resto %= 20;
            Console.WriteLine($"{cedula} nota(s) de R$ 20,00");
            cedula = resto / 10;
            resto %= 10;
            Console.WriteLine($"{cedula} nota(s) de R$ 10,00");
            cedula = resto / 5;
            resto %= 5;
            Console.WriteLine($"{cedula} nota(s) de R$ 5,00");
            cedula = resto / 2;
            resto %= 2;
            Console.WriteLine($"{cedula} nota(s) de R$ 2,00");
            cedula = resto;
            Console.WriteLine($"{cedula} nota(s) de R$ 1,00");
        }
    }
}