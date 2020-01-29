using System;
using System.Linq;

namespace uri2473
{
    internal static class Loteria
    {
        private static void Main()
        {
            string[] aposta = Console.ReadLine().Split(' ');
            string[] sorteio = Console.ReadLine().Split(' ');
            int[] apostados = new int[6];
            int[] sorteados = new int[6];
            int acertos = 0;

            for (int i = 0; i <= 5; i++)
            {
                int.TryParse(aposta[i], out apostados[i]);
                int.TryParse(sorteio[i], out sorteados[i]);
            }

            foreach (int numero in apostados)
            {
                if (sorteados.Contains(numero))
                {
                    acertos++;
                }
            }

            switch (acertos)
            {
                case 6:
                    Console.WriteLine("sena");
                    break;
                case 5:
                    Console.WriteLine("quina");
                    break;
                case 4:
                    Console.WriteLine("quadra");
                    break;
                case 3:
                    Console.WriteLine("terno");
                    break;
                default:
                    Console.WriteLine("azar");
                    break;
            }
        }
    }
}
