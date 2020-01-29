using System;

namespace uri1131 // Grenais
{
    internal static class Program
    {
        private static void Main()
        {
            int empates = 0;
            int totalInter = 0;
            int totalGremio = 0;
            int total = 0;
            int novo = 1;

            while (novo == 1)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                int.TryParse(entrada[0], out int inter);
                int.TryParse(entrada[1], out int gremio);
                if (inter > gremio)
                {
                    totalInter++;
                }
                else if (inter < gremio)
                {
                    totalGremio++;
                }
                else
                {
                    empates++;
                }

                total++;
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                int.TryParse(Console.ReadLine(), out novo);
            }

            Console.WriteLine($"{total} grenais\nInter:{totalInter}\nGremio:{totalGremio}\nEmpates:{empates}");
            if (totalInter > totalGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (totalInter < totalGremio)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }

            Console.ReadKey();
        }
    }
}