﻿using System;

namespace uri1428 // ProcurandoNessy
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int t);
            for (int i = 0; i < t; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                int.TryParse(str[0], out int n);
                int.TryParse(str[1], out int m);
                Console.WriteLine(n / 3 * (m / 3));
            }
        }
    }
}