using System;

namespace uri1864 // Nossos Dias Nunca Voltarão
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            string citacao = "Life is not a problem to be solved, but a reality to be experienced".ToUpper();
            Console.WriteLine(citacao.Substring(0, n));
        }
    }
}