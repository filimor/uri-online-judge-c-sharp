using System;

namespace uri1632
{
    internal static class Variacoes
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int t);
            for (int i = 0; i < t; i++)
            {
                int variacoes = 1;

                foreach (char letra in Console.ReadLine())
                {
                    switch (letra.ToString().ToLower())
                    {
                        case "a":
                        case "e":
                        case "i":
                        case "o":
                        case "s":
                            variacoes *= 3;
                            break;

                        default:
                            variacoes *= 2;
                            break;
                    }
                }

                Console.WriteLine(variacoes);
            }
        }
    }
}