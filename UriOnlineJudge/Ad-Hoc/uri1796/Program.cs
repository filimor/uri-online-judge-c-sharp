using System;

namespace uri1796 // Economia Brasileira
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int q);
            string[] str = Console.ReadLine().Split(' ');
            int opinioes = 0;

            for (int i = 0; i < q; i++)
            {
                if (str[i] == "0")
                {
                    opinioes++;
                }
            }

            Console.WriteLine(opinioes > str.Length / 2 ? "Y" : "N");
        }
    }
}