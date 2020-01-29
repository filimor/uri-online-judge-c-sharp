using System;

namespace uri1017 // Gasto de Combustível
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int tempo);
            int.TryParse(Console.ReadLine(), out int velocidade);
            Console.WriteLine((velocidade * tempo / 12.0).ToString("F3"));
        }
    }
}