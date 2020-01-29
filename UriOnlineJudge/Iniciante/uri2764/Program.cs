using System;

namespace uri2764 // Entrada e Saída de Data
{
    internal static class Program
    {
        private static void Main()
        {
            //DateTime.TryParse(Console.ReadLine(), out DateTime data);
            //Console.WriteLine(data.ToString("MM/dd/yy"));
            //Console.WriteLine(data.ToString("yy/MM/dd"));
            //Console.WriteLine(data.ToString("dd-MM-yy"));

            string[] data = Console.ReadLine().Split('/');
            string dia = data[0];
            string mes = data[1];
            string ano = data[2];
            Console.WriteLine($"{mes}/{dia}/{ano}");
            Console.WriteLine($"{ano}/{mes}/{dia}");
            Console.WriteLine($"{dia}-{mes}-{ano}");
        }
    }
}