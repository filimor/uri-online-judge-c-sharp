using System;

namespace uri1467 // Hello Galaxy
{
    internal static class Program
    {
        private static void Main()
        {
            string str;
            while ((str = Console.ReadLine()) != "0")
            {
                int.TryParse(str, out int n);
                int menorTempo = 3114;
                string planeta = string.Empty;

                for (int i = 0; i < n; i++)
                {
                    string[] dados = Console.ReadLine().Split(' ');
                    int.TryParse(dados[1], out int ano);
                    int.TryParse(dados[2], out int tempo);
                    int inicio = ano - tempo;
                    if (inicio < menorTempo)
                    {
                        menorTempo = inicio;
                        planeta = dados[0];
                    }
                }

                Console.WriteLine(planeta);
            }
        }
    }
}