using System;

namespace uri1310
{
    internal static class Lucro
    {
        private static void Main()
        {
            string str = Console.ReadLine();
            while (!string.IsNullOrEmpty(str))
            {
                int.TryParse(str, out int n);
                int.TryParse(Console.ReadLine(), out int custoPorDia);
                int[] receita = new int[n];
                for (int i = 0; i < n; i++)
                {
                    int.TryParse(Console.ReadLine(), out receita[i]);
                }

                int melhorReceita = 0;
                for (int diaInicial = 0; diaInicial < n; diaInicial++)
                {
                    int receitaTemporada = 0;
                    for (int diaFinal = diaInicial; diaFinal < n; diaFinal++)
                    {
                        receitaTemporada += receita[diaFinal] - custoPorDia;
                        if (receitaTemporada > melhorReceita)
                        {
                            melhorReceita = receitaTemporada;
                        }
                    }
                }

                Console.WriteLine(melhorReceita);
                str = Console.ReadLine();
            }
        }
    }
}