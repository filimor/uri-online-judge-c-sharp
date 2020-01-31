using System;

namespace uri1985 // MacPRONALTS
{
    internal static class Program
    {
        private static void Main()
        {
            double total = 0.0;
            int.TryParse(Console.ReadLine(), out int p);

            for (int i = 0; i < p; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                int.TryParse(entrada[0], out int codigo);
                int.TryParse(entrada[1], out int quantidade);
                switch (codigo)
                {
                    case 1001:
                        total += quantidade * 1.5;
                        break;

                    case 1002:
                        total += quantidade * 2.5;
                        break;

                    case 1003:
                        total += quantidade * 3.5;
                        break;

                    case 1004:
                        total += quantidade * 4.5;
                        break;

                    case 1005:
                        total += quantidade * 5.5;
                        break;
                }
            }

            Console.WriteLine(total.ToString("F2"));
        }
    }
}