using System;

namespace uri2464
{
    internal static class Decifra
    {
        private static void Main()
        {
            string sequencia = Console.ReadLine();
            string frase = Console.ReadLine();
            string mensagem = string.Empty;

            for (int i = 0; i < frase.Length; i++)
            {
                mensagem += sequencia[Convert.ToInt32(frase[i] - 97)];
            }

            Console.WriteLine(mensagem);
        }
    }
}