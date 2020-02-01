using System;

namespace uri1140 // Flores Florescem da França
{
    internal static class Program
    {
        private static void Main()
        {
            string str;
            while ((str = Console.ReadLine()) != "*")
            {
                bool tautograma = true;
                string[] palavras = str.Split(' ');
                char letra = palavras[0].ToLower()[0];
                foreach (string palavra in palavras)
                {
                    if (palavra.ToLower()[0] != letra)
                    {
                        tautograma = false;
                    }
                }
                Console.WriteLine(tautograma ? "Y" : "N");
            }
        }
    }
}