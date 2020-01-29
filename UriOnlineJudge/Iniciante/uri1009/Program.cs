using System;

namespace uri1009 // Salário com Bônus
{
    internal static class Program
    {
        private static void Main()
        {
            Console.ReadLine();
            double.TryParse(Console.ReadLine(), out double salario);
            double.TryParse(Console.ReadLine(), out double vendas);
            Console.WriteLine($"TOTAL = R$ {(salario + (vendas * 0.15)).ToString("F2")}");
        }
    }
}