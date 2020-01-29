using System;

namespace uri1037 // Intervalo
{
    internal static class Program
    {
        private static void Main()
        {
            double.TryParse(Console.ReadLine(), out double numero);
            if ((numero >= 0.0) && (numero <= 25.0))
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if ((numero > 25.0) && (numero <= 50.0))
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if ((numero > 50.0) && (numero <= 75.0))
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if ((numero > 75.0) && (numero <= 100.0))
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}