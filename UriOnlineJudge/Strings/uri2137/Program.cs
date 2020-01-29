using System;

namespace uri2137
{
    internal static class ABilbiotecaDoSenhorSeverino
    {
        private static void Main()
        {
            string entrada = Console.ReadLine();
            while (!string.IsNullOrEmpty(entrada))
            {
                int.TryParse(entrada, out int n);
                string[] livros = new string[n];
                for (int i = 0; i < n; i++)
                {
                    livros[i] = Console.ReadLine();
                }
                Array.Sort(livros);
                foreach (string item in livros)
                {
                    Console.WriteLine(item);
                }
                entrada = Console.ReadLine();
            }
        }
    }
}