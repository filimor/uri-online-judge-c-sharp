using System;

namespace uri2126 // Procurando Subsequências
{
    internal static class Program
    {
        private static void Main()
        {
            string n1;

            for (int caso = 1;
                !string.IsNullOrEmpty(n1 = Console.ReadLine());
                caso++)
            {
                string n2 = Console.ReadLine();
                int n1Length = n1.Length;
                int n2Length = n2.Length;

                int sub = 0, pos = 0;
                for (int i = 0; i <= n2Length - n1Length; i++)
                {
                    if (n2.Substring(i, n1Length) == n1)
                    {
                        sub++;
                        pos = i + 1;
                    }
                }
                Console.WriteLine($"Caso #{caso}:");
                if (pos > 0)
                {
                    Console.WriteLine("Qtd.Subsequencias: " + sub);
                    Console.WriteLine("Pos: " + pos);
                }
                else
                {
                    Console.WriteLine("Nao existe subsequencia");
                }
                Console.WriteLine();
            }
        }
    }
}