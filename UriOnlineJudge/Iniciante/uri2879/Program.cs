using System;

namespace uri2879
{
    static internal class DesvendandoMontyHall
    {
        private static void Main()
        {
            int vitorias = 0;
            int.TryParse(Console.ReadLine(), out int n);
            for (int i = 0; i < n; i++)
            {
                int.TryParse(Console.ReadLine(), out int carro);
                if (carro != 1)
                {
                    vitorias++;
                }
            }
            Console.WriteLine(vitorias);
        }
    }
}