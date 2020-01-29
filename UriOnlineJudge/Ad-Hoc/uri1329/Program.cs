using System;

namespace uri1329 // Cara ou Coroa
{
    internal static class Program
    {
        private static void Main()
        {
            string str;
            while ((str = Console.ReadLine()) != "0")
            {
                int.TryParse(str, out int n);
                string[] linha = Console.ReadLine().Split(' ');
                int joao = 0;
                int maria = 0;

                for (int i = 0; i < n; i++)
                {
                    if (linha[i] == "0")
                    {
                        maria++;
                    }
                    else if (linha[i] == "1")
                    {
                        joao++;
                    }
                }

                Console.WriteLine($"Mary won {maria} times and John won {joao} times");
            }
        }
    }
}