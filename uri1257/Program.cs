using System;

namespace uri1257
{
    internal static class ArrayHash
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            for (int i = 0; i < n; i++)
            {
                int hash = 0;
                int.TryParse(Console.ReadLine(), out int l);
                string[] str = new string[l];
                for (int j = 0; j < l; j++)
                {
                    str[j] = Console.ReadLine();
                    for (int k = 0; k < str[j].Length; k++)
                    {
                        hash += Convert.ToInt32(str[j][k]) - 65 + j + k;
                    }
                }
                Console.WriteLine(hash);
            }
        }
    }
}