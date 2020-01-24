using System;

namespace uri1936 // Fatorial
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            for (int i = 1; ; i++)
            {
                int teste = 0;
                for (int j = 1; j<n; j++)
                {
                    int temp = teste;
                    teste += Fatorial(j);
                    if (teste == n)
                    {
                        Console.WriteLine(teste);
                        return;
                    }else if (teste > n)
                    {
                        teste = temp;
                        break;
                    }
                }
            }
        }

        private static int Fatorial(int x)
        {
            int resultado = 1;
            for (int n = 1; n <= x; n++)
            {
                resultado *= n;
            }
            return resultado;
        }
    }
}
