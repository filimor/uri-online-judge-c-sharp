using System;

namespace uri2328
{
    internal static class Chocolate
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            string[] e = Console.ReadLine().Split(' ');
            int[] i = new int[n];
            int estoque = 0;

            for (int x = 0; x < n; x++)
            {
                int.TryParse(e[x], out i[x]);
                //estoque += Convert.ToInt32(e[x]);
                estoque += i[x];
                estoque--;
            }

            Console.WriteLine(estoque);
        }
    }
}