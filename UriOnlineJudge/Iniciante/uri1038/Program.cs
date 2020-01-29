using System;

namespace uri1038 // Lanche
{
    internal static class Program
    {
        private static void Main()
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int.TryParse(entrada[0], out int produto);
            int.TryParse(entrada[1], out int quantidade);

            switch (produto)
            {
                case 1:
                    Console.WriteLine($"Total: R$ {(quantidade * 4.0).ToString("F2")}");
                    break;

                case 2:
                    Console.WriteLine($"Total: R$ {(quantidade * 4.5).ToString("F2")}");
                    break;

                case 3:
                    Console.WriteLine($"Total: R$ {(quantidade * 5.0).ToString("F2")}");
                    break;

                case 4:
                    Console.WriteLine($"Total: R$ {(quantidade * 2.0).ToString("F2")}");
                    break;

                case 5:
                    Console.WriteLine($"Total: R$ {(quantidade * 1.5).ToString("F2")}");
                    break;
            }
        }
    }
}