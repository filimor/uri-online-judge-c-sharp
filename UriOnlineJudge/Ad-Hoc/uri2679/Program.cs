using System;

namespace uri2679
{
    internal static class SucessorPar
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int x);
            Console.WriteLine(x % 2 == 0 ? x + 2 : x + 1);
        }
    }
}