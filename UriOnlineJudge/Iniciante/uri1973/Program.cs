using System;
using System.IO;

namespace uri1973 // Jornada nas Estrelas
{
    internal static class Program
    {
        private static void Main()
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(16384)));

            long.TryParse(Console.ReadLine(), out long qtdSitios);
            string[] entrada = Console.ReadLine().Split(' ');
            ulong[] carneiros = new ulong[qtdSitios];
            bool[] sitiosAtacados = new bool[qtdSitios];
            ulong carneirosTotais = 0;
            ulong carneirosRoubados = 0;
            long sitioAtual = 0;
            ulong sitiosRoubados = 0;
            for (int i = 0; i < qtdSitios; i++)
            {
                ulong.TryParse(entrada[i], out carneiros[i]);
                carneirosTotais += carneiros[i];
            }
            do
            {
                if (carneiros[sitioAtual] > 0)
                {
                    carneiros[sitioAtual]--;
                    sitiosAtacados[sitioAtual] = true;
                    carneirosRoubados++;
                    if ((carneiros[sitioAtual] + 1) % 2 != 0)
                    {
                        sitioAtual++;
                    }
                    else
                    {
                        sitioAtual--;
                    }
                }
                else
                {
                    sitioAtual--;
                }
            } while (sitioAtual < qtdSitios && sitioAtual >= 0);
            foreach (bool item in sitiosAtacados)
            {
                if (item)
                {
                    sitiosRoubados++;
                }
            }
            Console.WriteLine(sitiosRoubados + " " + (carneirosTotais - carneirosRoubados));
        }
    }
}