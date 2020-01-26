using System;

namespace uri2717 // Tempo do Duende
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            string[] str = Console.ReadLine().Split(' ');
            int.TryParse(str[0], out int a);
            int.TryParse(str[1], out int b);
            Console.WriteLine(a + b <= n ? "Farei hoje!" : "Deixa para amanha!");
        }
    }
}