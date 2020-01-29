using System;

namespace uri1016 // Distância
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int distancia);
            Console.WriteLine($"{distancia / 0.5} minutos");
        }
    }
}