using System;

namespace uri1876 // Rabiola
{
    internal static class Program
    {
        private static void Main()
        {
            try
            {
                while (true)
                {
                    string[] p = Console.ReadLine().Split('x');
                    int total = p.Length;
                    int primeira = p[0].Length;
                    // int ultima = p[p.Length - 1].Length;
                    int ultima = p[^1].Length;
                    int maior = Math.Max(primeira, ultima);
                    for (int i = 1; i < total - 1; i++)
                    {
                        int atual = p[i].Length / 2;
                        if (atual > primeira && atual > ultima)
                        {
                            maior = atual;
                        }
                    }
                    Console.WriteLine(maior);
                }
            }
#pragma warning disable RCS1075, CA1031
            catch (Exception)
            {
            }
#pragma warning restore RCS1075, CA1031
        }
    }
}