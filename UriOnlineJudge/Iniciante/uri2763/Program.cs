using System;

namespace uri2763 // Entrada e Saída CPF
{
    internal static class Program
    {
        private static void Main()
        {
            string cpf = Console.ReadLine();
            Console.WriteLine(cpf.Substring(0, 3));
            Console.WriteLine(cpf.Substring(4, 3));
            Console.WriteLine(cpf.Substring(8, 3));
            Console.WriteLine(cpf.Substring(12, 2));
        }
    }
}