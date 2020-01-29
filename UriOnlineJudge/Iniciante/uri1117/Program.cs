using System;

namespace uri1117 // Validação de Nota
{
    internal static class Program
    {
        private static void Main()
        {
            double.TryParse(Console.ReadLine(), out double nota1);
            while ((nota1 < 0) || (nota1 > 10))
            {
                Console.WriteLine("nota invalida");
                double.TryParse(Console.ReadLine(), out nota1);
            }
            double.TryParse(Console.ReadLine(), out double nota2);
            while ((nota2 < 0) || (nota2 > 10))
            {
                Console.WriteLine("nota invalida");
                double.TryParse(Console.ReadLine(), out nota2);
            }
            Console.WriteLine($"media = {((nota1 + nota2) / 2.0).ToString("F2")}");
        }
    }
}