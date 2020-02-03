using System;
using System.Collections.Generic;
using System.Linq;

namespace uri1553 // Perguntas mais Frequentes
{
    internal static class Program
    {
        private static void Main()
        {
            string str;
            while ((str = Console.ReadLine()) != "0 0")
            {
                string[] entrada = str.Split(' ');
                int.TryParse(entrada[0], out int n);
                int.TryParse(entrada[1], out int k);
                entrada = Console.ReadLine().Split(' ');
                int[] p = new int[n];
                int faqs = 0;

                for (int i = 0; i < n; i++)
                {
                    int.TryParse(entrada[i], out p[i]);
                }

                var counts = p.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());

                foreach (KeyValuePair<int, int> item in counts)
                {
                    if (item.Value >= k)
                    {
                        faqs++;
                    }
                }

                Console.WriteLine(faqs);
            }
        }
    }
}