using System;
using System.Linq;

namespace uri2414
{
    internal static class DesafioDoMaiorNumero
    {
        private static void Main()
        {
            string[] str = Console.ReadLine().Split(' ');
            int[] mat = new int[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                int.TryParse(str[i], out mat[i]);
            }

            Console.WriteLine(mat.Max());
        }
    }
}