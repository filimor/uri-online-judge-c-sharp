using System;

namespace uri2752
{
    internal static class Saida6
    {
        private static void Main()
        {
            const string str = "AMO FAZER EXERCICIO NO URI";
            Console.WriteLine($"<{str}>");
            Console.WriteLine($"<    {str}>");
            Console.WriteLine($"<{str.Substring(0, 19)} >");
            Console.WriteLine($"<{str}>");
            Console.WriteLine($"<{str}    >");
            Console.WriteLine($"<{str}>");
            Console.WriteLine($"<          {str.Substring(0, 19)} >");
            Console.WriteLine($"<{str.Substring(0, 19)}           >");
        }
    }
}