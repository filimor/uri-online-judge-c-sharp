using System;

namespace uri1397
{
    internal static class JogoDoMaior
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            while (n != 0)
            {
                int pa = 0;
                int pb = 0;

                for (int i = 0; i < n; i++)
                {
                    string[] str = Console.ReadLine().Split(' ');
                    int.TryParse(str[0], out int a);
                    int.TryParse(str[1], out int b);
                    if (a > b)
                    {
                        pa++;
                    }
                    else if (b > a)
                    {
                        pb++;
                    }
                }

                Console.WriteLine($"{pa} {pb}");
                int.TryParse(Console.ReadLine(), out n);
            }
        }
    }
}