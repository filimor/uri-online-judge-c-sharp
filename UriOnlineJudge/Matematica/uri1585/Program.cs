using System;

namespace uri1585
{
    static internal class FazendoPandorgas
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            for (int i = 0; i < n; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                double.TryParse(str[0], out double x);
                double.TryParse(str[1], out double y);
                Console.WriteLine($"{(int)(x / 2 * y / 2 / 2 * 4)} cm2");
            }
        }
    }
}