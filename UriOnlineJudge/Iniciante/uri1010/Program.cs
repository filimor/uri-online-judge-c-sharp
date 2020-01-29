using System;

namespace uri1010 // Cálculo Simples
{
    internal static class Program
    {
        private static void Main()
        {
            string[] entrada1 = Console.ReadLine().Split(' ');
            string[] entrada2 = Console.ReadLine().Split(' ');

            int.TryParse(entrada1[1], out int numeroPecas1);
            double.TryParse(entrada1[2], out double valorPeca1);
            int.TryParse(entrada2[1], out int numeroPecas2);
            double.TryParse(entrada2[2], out double valorPeca2);

            double total = (numeroPecas1 * valorPeca1) + (numeroPecas2 * valorPeca2);
            Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2")}");
        }
    }
}