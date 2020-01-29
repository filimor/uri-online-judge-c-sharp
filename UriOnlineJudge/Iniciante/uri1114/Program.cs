using System;

namespace uri1114 // Senha Fixa
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int senha);
            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                int.TryParse(Console.ReadLine(), out senha);
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}