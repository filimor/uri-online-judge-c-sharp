using System;

namespace uri1961 // Pula Sapo
{
    internal static class Program
    {
        private static void Main()
        {
            string[] entrada1 = Console.ReadLine().Split(' ');
            string[] entrada2 = Console.ReadLine().Split(' ');
            int.TryParse(entrada1[0], out int p);
            int.TryParse(entrada1[1], out int n);
            int[] canos = new int[n];
            bool gameover = false;

            int.TryParse(entrada2[0], out canos[0]);
            for (int i = 1; i < n; i++)
            {
                int.TryParse(entrada2[i], out canos[i]);
                if (canos[i] - canos[i - 1] > p || canos[i - 1] - canos[i] > p)
                {
                    gameover = true;
                }
            }

            Console.WriteLine(gameover ? "GAME OVER" : "YOU WIN");
        }
    }
}