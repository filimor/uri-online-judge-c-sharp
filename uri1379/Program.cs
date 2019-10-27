using System;

namespace uri1379
{
    internal static class ProblemaComMedianaEMedia
    {
        private static void Main()
        {
            string[] str = Console.ReadLine().Split(' ');
            while (str[0] != "0" && str[1] != "0")
            {
                int.TryParse(str[0], out int a);
                int.TryParse(str[1], out int b);

                for (int c = b * -1; ; c++)
                {
                    if ((a + b + c) / 3 == Math.Max(a, c))
                    {
                        Console.WriteLine(c);
                        break;
                    }
                }
                str = Console.ReadLine().Split(' ');
            }
        }
    }
}