using System;

namespace uri2146 // Senha
{
    internal static class Program
    {
        private static void Main()
        {
            string str;
            while (!string.IsNullOrEmpty(str = Console.ReadLine()))
            {
                int.TryParse(str, out int n);
                Console.WriteLine(n - 1);
            }
        }
    }
}