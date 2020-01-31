using System;

namespace uri2006 // Identificando o Chá
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int t);
            int acertos = 0;
            foreach (string s in Console.ReadLine().Split(' '))
            {
                if (int.Parse(s) == t)
                {
                    acertos++;
                }
            }
            Console.WriteLine(acertos);
        }
    }
}