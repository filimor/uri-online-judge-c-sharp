using System;
using System.Globalization;

namespace uri1021 // Notas e Moedas
{
    internal static class Program
    {
        private static void Main()
        {
            double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double valor);
            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{(int)(valor / 100)} nota(s) de R$ 100.00");
            valor %= 100;
            Console.WriteLine($"{(int)(valor / 50)} nota(s) de R$ 50.00");
            valor %= 50;
            Console.WriteLine($"{(int)(valor / 20)} nota(s) de R$ 20.00");
            valor %= 20;
            Console.WriteLine($"{(int)(valor / 10)} nota(s) de R$ 10.00");
            valor %= 10;
            Console.WriteLine($"{(int)(valor / 5)} nota(s) de R$ 5.00");
            valor %= 5;
            Console.WriteLine($"{(int)(valor / 2)} nota(s) de R$ 2.00");
            valor %= 2;

            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{(int)valor} moeda(s) de R$ 1.00");
            valor = valor % 1 * 100;
            Console.WriteLine($"{(int)(valor / 50)} moeda(s) de R$ 0.50");
            valor %= 50;
            Console.WriteLine($"{(int)(valor / 25)} moeda(s) de R$ 0.25");
            valor %= 25;
            Console.WriteLine($"{(int)(valor / 10)} moeda(s) de R$ 0.10");
            valor %= 10;
            Console.WriteLine($"{(int)(valor / 5)} moeda(s) de R$ 0.05");
            valor %= 5;
            Console.WriteLine($"{(int)valor} moeda(s) de R$ 0.01");
        }
    }
}