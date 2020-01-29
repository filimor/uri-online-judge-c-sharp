using System;

namespace uri2949 // A Sociedade do Anel
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            int a = 0;
            int e = 0;
            int h = 0;
            int m = 0;
            int x = 0;

            for (int i = 0; i < n; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                switch (str[1])
                {
                    case "A":
                        a++;
                        break;
                    case "E":
                        e++;
                        break;
                    case "H":
                        h++;
                        break;
                    case "M":
                        m++;
                        break;
                    case "X":
                        x++;
                        break;
                }
            }

            Console.WriteLine($"{x} Hobbit(s)");
            Console.WriteLine($"{h} Humano(s)");
            Console.WriteLine($"{e} Elfo(s)");
            Console.WriteLine($"{a} Anao(s)");
            Console.WriteLine($"{m} Mago(s)");
        }
    }
}