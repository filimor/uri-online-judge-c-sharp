using System;

namespace uri1848 // Corvo Contador
{
    internal static class Program
    {
        private static void Main()
        {
            int gritos = 0;
            int numero = 0;
            while (gritos < 3)
            {
                string entrada = Console.ReadLine();
                if (entrada == "caw caw")
                {
                    gritos++;
                    Console.WriteLine(numero);
                    numero = 0;
                }
                else
                {
                    if (entrada[0] == '*')
                    {
                        numero += 4;
                    }

                    if (entrada[1] == '*')
                    {
                        numero += 2;
                    }

                    if (entrada[2] == '*')
                    {
                        numero++;
                    }
                }
            }
        }
    }
}