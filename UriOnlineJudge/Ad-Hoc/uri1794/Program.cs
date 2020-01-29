using System;

namespace uri1794
{
    internal static class Lavanderia
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            string[] str = Console.ReadLine().Split(' ');
            int.TryParse(str[0], out int lA);
            int.TryParse(str[1], out int lB);
            str = Console.ReadLine().Split(' ');
            int.TryParse(str[0], out int sA);
            int.TryParse(str[1], out int sB);

            if (n >= lA && n >= sA && n <= lB && n <= sB)
            {
                Console.WriteLine("possivel");
            }
            else
            {
                Console.WriteLine("impossivel");
            }
        }
    }
}