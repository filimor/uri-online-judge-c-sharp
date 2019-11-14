using System;

namespace uri1936
{
    internal static class Fatorial
    {
        private static void Main()
        {
            
        }
        private static int CalculaFatorial(int x)
        {
            int resultado = 1;
            for (int i = 1; i <= x; i++)
            {
                resultado *= i;
            }
            return resultado;
        }
    }
}
