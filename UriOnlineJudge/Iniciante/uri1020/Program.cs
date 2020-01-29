using System;

namespace uri1020 // Idade em Dias
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int entrada);
            Console.WriteLine($"{entrada / 365} ano(s)\n" +
                $"{entrada % 365 / 30} mes(es)\n" +
                $"{entrada % 365 % 30} dia(s)");
        }
    }
}