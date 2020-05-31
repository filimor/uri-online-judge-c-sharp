using System;

namespace uri2714 // Minha Senha Provisória
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            for (int i = 0; i < n; i++)
            {
                string ra = Console.ReadLine();
                long.TryParse(ra.Substring(2), out long senha);

                if (ra.Length == 20 &&
                    ra.Substring(0, 2) == "RA" &&
                    senha != 0)
                {
                    Console.WriteLine(senha);
                }
                else
                {
                    Console.WriteLine("INVALID DATA");
                }
            }
        }
    }
}