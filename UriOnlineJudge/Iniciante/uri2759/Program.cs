using System;

namespace uri2759
{
    internal static class EntradaESaidaDeCaracter
    {
        private static void Main()
        {
            char a = Convert.ToChar(Console.ReadLine());
            char b = Convert.ToChar(Console.ReadLine());
            char c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"A = {a}, B = {b}, C = {c}");
            Console.WriteLine($"A = {b}, B = {c}, C = {a}");
            Console.WriteLine($"A = {c}, B = {a}, C = {b}");
        }
    }
}