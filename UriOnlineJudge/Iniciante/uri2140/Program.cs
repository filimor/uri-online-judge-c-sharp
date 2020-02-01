using System;

namespace uri2140 // Duas Notas
{
    internal static class Program
    {
        private static void Main()
        {
            string[] str = Console.ReadLine().Split(' ');
            int.TryParse(str[0], out int n);
            int.TryParse(str[1], out int m);

            while (m != 0 && n != 0)
            {
                int troco = m - n;
                int cedulas = 0;

                while (troco >= 100 && cedulas <= 2)
                {
                    troco -= 100;
                    cedulas++;
                }
                while (troco >= 50 && cedulas <= 2)
                {
                    troco -= 50;
                    cedulas++;
                }
                while (troco >= 20 && cedulas <= 2)
                {
                    troco -= 20;
                    cedulas++;
                }
                while (troco >= 10 && cedulas <= 2)
                {
                    troco -= 10;
                    cedulas++;
                }
                while (troco >= 5 && cedulas <= 2)
                {
                    troco -= 5;
                    cedulas++;
                }
                while (troco >= 2 && cedulas <= 2)
                {
                    troco -= 2;
                    cedulas++;
                }

                int troco2 = m - n;
                Console.WriteLine((troco == 0 && cedulas == 2) ||
                    troco2 == 4 || troco2 == 10 || troco2 == 20 ||
                    troco2 == 40 || troco2 == 100 || troco2 == 200
                    ? "possible" : "impossible");
                str = Console.ReadLine().Split(' ');
                int.TryParse(str[0], out n);
                int.TryParse(str[1], out m);
            }
        }
    }
}