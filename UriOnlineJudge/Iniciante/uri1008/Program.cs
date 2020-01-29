using System;

namespace uri1008 // Salário
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int numero);
            int.TryParse(Console.ReadLine(), out int horas);
            double.TryParse(Console.ReadLine(), out double valorHora);
            Console.WriteLine($"NUMBER = {numero}");
            Console.WriteLine($"SALARY = U$ {(horas * valorHora).ToString("F2")}");
        }
    }
}