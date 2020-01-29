using System;

namespace uri1160 // Crescimento Populacional
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int t);

            int tempo;

            for (int i = 1; i <= t; i++)
            {
                tempo = 0;
                string[] entrada = Console.ReadLine().Split(' ');
                int.TryParse(entrada[0], out int pa);
                int.TryParse(entrada[1], out int pb);
                double.TryParse(entrada[2], out double g1);
                double.TryParse(entrada[3], out double g2);

                do
                {
                    pa += (int)(pa * g1 / 100);
                    pb += (int)(pb * g2 / 100);
                    tempo++;
                    if (tempo > 100)
                    {
                        break;
                    }
                } while (pa <= pb);

                if (tempo > 100)
                {
                    Console.WriteLine("Mais de 1 seculo.");
                }
                else
                {
                    Console.WriteLine($"{tempo} anos.");
                }
            }
        }
    }
}