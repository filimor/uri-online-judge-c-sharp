using System;

namespace uri1436 // Jogo do Tijolo
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int t);
            for (int i = 1; i <= t; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                int.TryParse(entrada[0], out int n);
                int idade = 0;
                switch (n)
                {
                    case 3:
                        int.TryParse(entrada[2], out idade);
                        break;

                    case 5:
                        int.TryParse(entrada[3], out idade);
                        break;

                    case 7:
                        int.TryParse(entrada[4], out idade);
                        break;

                    case 9:
                        int.TryParse(entrada[5], out idade);
                        break;
                }
                Console.WriteLine($"Case {i}: {idade}");
            }
        }
    }
}