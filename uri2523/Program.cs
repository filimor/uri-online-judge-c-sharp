using System;

namespace uri2523
{
    internal static class AMensagemDeWill
    {
        private static void Main()
        {
            string entrada = Console.ReadLine();
            while (!string.IsNullOrEmpty(entrada))
            {
                int.TryParse(Console.ReadLine(), out int n);
                string[] str = Console.ReadLine().Split(' ');

                for (int i = 0; i < n; i++)
                {
                    int.TryParse(str[i], out int l);
                    Console.Write(entrada[l - 1]);
                }
                Console.WriteLine();

                entrada = Console.ReadLine();
            }
        }
    }
}