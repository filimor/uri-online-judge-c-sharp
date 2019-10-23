using System;

namespace uri1091
{
    internal static class DivisaoDaNlogonia
    {
        private static void Main()
        {
            while (true)
            {
                int.TryParse(Console.ReadLine(), out int k);
                if (k == 0)
                {
                    return;
                }
                string[] str = Console.ReadLine().Split(' ');
                int.TryParse(str[0], out int n);
                int.TryParse(str[1], out int m);
                for (int i = 0; i < k; i++)
                {
                    string[] casa = Console.ReadLine().Split(' ');
                    int.TryParse(casa[0], out int x);
                    int.TryParse(casa[1], out int y);

                    if (x == n || y == m)
                    {
                        Console.WriteLine("divisa");
                    }
                    else if (x > n && y > m)
                    {
                        Console.WriteLine("NE");
                    }
                    else if (x > n && y < m)
                    {
                        Console.WriteLine("SE");
                    }
                    else if (x < n && y < m)
                    {
                        Console.WriteLine("SO");
                    }
                    else if (x < n && y > m)
                    {
                        Console.WriteLine("NO");
                    }
                }
            }
        }
    }
}