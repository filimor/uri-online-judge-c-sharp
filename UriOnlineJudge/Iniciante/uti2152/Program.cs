using System;

namespace uri2152 // Pepe, Já Tirei a Vela!
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int t);
            for (int i = 0; i < t; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                int.TryParse(str[0], out int h);
                int.TryParse(str[1], out int m);
                int.TryParse(str[2], out int o);

                Console.Write($"{h.ToString("00")}:{m.ToString("00")} - A porta ");
                Console.WriteLine((o == 1) ? "abriu!" : "fechou!");
            }
        }
    }
}