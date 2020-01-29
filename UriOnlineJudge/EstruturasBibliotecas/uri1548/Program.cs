using System;

namespace uri1548
{
    internal static class FilaDoRecreio
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            for (int i = 0; i < n; i++)
            {
                int.TryParse(Console.ReadLine(), out int m);
                int r = m;
                string[] str = Console.ReadLine().Split(' ');
                int[] p = new int[m];
                int[] q = new int[m];
                for (int j = 0; j < m; j++)
                {
                    int.TryParse(str[j], out p[j]);
                    q[j] = p[j];
                }
                Array.Sort(q);
                Array.Reverse(q);
                for (int k = 0; k < m; k++)
                {
                    if (p[k] != q[k])
                    {
                        r--;
                    }
                }
                Console.WriteLine(r);
            }
        }
    }
}