using System;

namespace uri1387
{
    internal static class Og
    {
        private static void Main()
        {
            string entrada = Console.ReadLine();
            while (entrada != "0 0")
            {
                string[] str = entrada.Split(' ');
                int.TryParse(str[0], out int l);
                int.TryParse(str[1], out int r);
                Console.WriteLine(l + r);
                entrada = Console.ReadLine();
            }
        }
    }
}