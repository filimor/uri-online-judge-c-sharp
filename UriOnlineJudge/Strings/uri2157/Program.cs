using System;
using System.Text;
using System.Linq;

namespace uri2157 // Sequência Espelho
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int c);

            for (int i = 0; i < c; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                int.TryParse(str[0], out int b);
                int.TryParse(str[1], out int e);

                var sb = new StringBuilder();
                int tamanho = e - b + 1;

                for (int j = 0; j < tamanho; j++)
                {
                    sb.Append(b + j);
                }

                for (int k = 0; k < tamanho; k++)
                {
                    sb.Append((e - k).ToString().Reverse().ToArray());
                }

                Console.WriteLine(sb.ToString());
            }
        }
    }
}