using System;

namespace uri2061 // As Abas de Péricles
{
    internal static class Program
    {
        private static void Main()
        {
            string[] str = Console.ReadLine().Split(' ');
            int.TryParse(str[0], out int n);
            int.TryParse(str[1], out int m);
            for (int i = 0; i < m; i++)
            {
                if (Console.ReadLine() == "fechou")
                {
                    n++;
                }
                else
                {
                    n--;
                }
            }
            Console.WriteLine(n);
        }
    }
}