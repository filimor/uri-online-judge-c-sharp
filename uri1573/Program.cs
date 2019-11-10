using System;

namespace uri1573
{
    internal static class FabricaDeChocolate
    {
        private static void Main()
        {
            string[] str = Console.ReadLine().Split(' ');
            while (str[0] != "0" && str[1] != "0" && str[2] != "0")
            {
                int.TryParse(str[0], out int a);
                int.TryParse(str[1], out int b);
                int.TryParse(str[2], out int c);
                Console.WriteLine(Math.Floor(Math.Cbrt(a * b * c)));
                str = Console.ReadLine().Split(' ');
            }
        }
    }
}