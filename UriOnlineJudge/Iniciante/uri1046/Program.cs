using System;

namespace uri1046 // Tempo de Jogo
{
    internal static class Program
    {
        private static void Main()
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int.TryParse(entrada[0], out int inicio);
            int.TryParse(entrada[1], out int termino);

            if (termino > inicio)
            {
                Console.WriteLine($"O JOGO DUROU {termino - inicio} HORA(S)");
            }
            else if (inicio > termino)
            {
                Console.WriteLine($"O JOGO DUROU {24 - inicio + termino} HORA(S)");
            }
            else
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }
            Console.ReadKey();
        }
    }
}