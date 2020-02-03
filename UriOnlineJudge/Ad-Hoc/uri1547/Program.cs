using System;

namespace uri1547 // Adivinha
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            for (int i = 0; i < n; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                int.TryParse(str[0], out int qt);
                int.TryParse(str[1], out int s);
                str = Console.ReadLine().Split(' ');
                int[] numeros = new int[qt];
                int menorDiferenca = int.MaxValue;
                int vencedor = 0;

                for (int j = 0; j < qt; j++)
                {
                    int.TryParse(str[j], out numeros[j]);
                    int diferenca = Math.Abs(numeros[j] - s);
                    if (diferenca < menorDiferenca)
                    {
                        vencedor = j;
                        menorDiferenca = diferenca;
                    }
                }

                Console.WriteLine(vencedor + 1);
            }
        }
    }
}