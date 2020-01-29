using System;

namespace uri1262 // Leitura Múltipla
{
    internal static class Program
    {
        private static void Main()
        {
            string str;
            while (!string.IsNullOrEmpty(str = Console.ReadLine()))
            {
                int.TryParse(Console.ReadLine(), out int p);
                int ciclos = 0;
                int processo = 0;
                char ultimo = '\0';

                foreach (char c in str)
                {
                    switch (c)
                    {
                        case 'R':
                            if (ultimo == 'W' || ultimo == '\0')
                            {
                                ciclos++;
                                processo++;
                            }
                            else if (processo >= p)
                            {
                                ciclos++;
                                processo = 1;
                            }
                            else
                            {
                                processo++;
                            }
                            ultimo = 'R';
                            break;

                        case 'W':
                            ciclos++;
                            processo = 0;
                            ultimo = 'W';
                            break;
                    }
                }

                Console.WriteLine(ciclos);
            }
        }
    }
}