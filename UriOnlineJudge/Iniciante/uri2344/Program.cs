using System;

namespace uri2344
{
    internal static class NotasdaProva
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            Console.WriteLine((n == 0) ?
                'E' : (n <= 35) ?
                'D' : (n <= 60) ?
                'C' : (n <= 85) ?
                'B' : 'A');
        }
    }
}