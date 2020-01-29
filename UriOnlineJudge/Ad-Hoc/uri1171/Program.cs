using System;
using System.Collections.Generic;
using System.Linq;

namespace uri1171 // Frequência de Números
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            var numeros = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int.TryParse(Console.ReadLine(), out int num);
                numeros.Add(num);
            }

            var q = numeros.GroupBy(x => x)
                .Select(x => new
                {
                    Count = x.Count(),
                    Name = x.Key
                })
                .OrderBy(x => x.Name);

            foreach (var x in q)
            {
                Console.WriteLine($"{x.Name} aparece {x.Count} vez(es)");
            }
        }
    }
}