// TODO: Não passa em todos os casos de teste.

using System;
using System.Collections.Generic;

namespace uri2952 // A Vida Sustentável
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            string[] str = Console.ReadLine().Split(' ');
            var cb = new List<int>();
            bool primeiraJogada = true;
            int maiorCb = 0;
            int menorCb = 0;

            for (int i = 0; i < n; i++)
            {
                if (str[i] == "N" && primeiraJogada)
                {
                    continue;
                }
                else
                {
                    primeiraJogada = false;
                }

                switch (str[i])
                {
                    case "A":
                        cb.Add(-50);
                        break;

                    case "C":
                        cb.Add(-13500);
                        break;

                    case "S":
                        cb.Add(200);
                        break;

                    case "P":
                        cb.Add(550);
                        break;

                    case "M":
                        cb.Add(13000);
                        break;

                    case "K":
                        cb.Add(-20);
                        break;

                    case "B":
                        cb.Add(40);
                        break;

                    case "N":
                        cb.Add(0);
                        break;
                }
            }

            for (int j = 0; j < n; j++)
            {
                int intervalo = 0;
                for (int k = j; k < n; k++)
                {
                    intervalo += cb[k];
                    if (intervalo > maiorCb)
                    {
                        maiorCb = intervalo;
                    }
                    if (intervalo < menorCb)
                    {
                        menorCb = intervalo;
                    }
                }
            }

            Console.WriteLine($"{maiorCb} {menorCb}");
        }
    }
}