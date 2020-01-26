using System;

namespace uri2766 // Entrada e Saída Lendo e Pulando Nomes
{
    internal static class Program
    {
        private static void Main()
        {
            string[] nomes = new string[10];
            for (int i = 0; i < 10; i++)
            {
                nomes[i] = Console.ReadLine();
            }
            Console.WriteLine($"{nomes[2]}\n{nomes[6]}\n{nomes[8]}");
        }
    }
}