using System;

namespace uri1115 // Quadrante
{
    internal static class Program
    {
        private static void Main()
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int.TryParse(entrada[0], out int x);
            int.TryParse(entrada[1], out int y);
            while ((x != 0) && (y != 0))
            {
                if ((x > 0) && (y > 0))
                {
                    Console.WriteLine("primeiro");
                }
                else if ((x < 0) && (y > 0))
                {
                    Console.WriteLine("segundo");
                }
                else if ((x < 0) && (y < 0))
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }

                entrada = Console.ReadLine().Split(' ');
                int.TryParse(entrada[0], out x);
                int.TryParse(entrada[1], out y);
            }
        }
    }
}