using System;
using System.Text;

namespace uri1238
{
    internal static class Combinador
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            for (int i = 0; i < n; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                string string1 = str[0];
                string string2 = str[1];
                string menor, maior;

                if (string1.Length > string2.Length)
                {
                    menor = string2;
                    maior = string1;
                }
                else
                {
                    menor = string1;
                    maior = string2;
                }

                var sb = new StringBuilder();

                for (int j = 0; j < menor.Length; j++)
                {
                    sb.Append(string1[j]);
                    sb.Append(string2[j]);
                }
                sb.Append(maior, menor.Length, maior.Length - menor.Length);

                Console.WriteLine(sb.ToString());
            }
        }
    }
}