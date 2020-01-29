using System;

namespace uri2381
{
    internal static class ListaDeChamada
    {
        private static void Main()
        {
            string[] str = Console.ReadLine().Split(' ');
            int.TryParse(str[0], out int n);
            int.TryParse(str[1], out int k);
            string[] nomes = new string[n];
            for (int i = 0; i < n; i++)
            {
                nomes[i] = Console.ReadLine();
            }
            Array.Sort(nomes);
            Console.WriteLine(nomes[k - 1]);
        }
    }
}