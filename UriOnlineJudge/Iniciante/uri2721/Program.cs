using System;

namespace uri2721 // Indecisão das Renas
{
    internal static class Program
    {
        private static void Main()
        {
            string[] str = Console.ReadLine().Split(' ');
            int bolas = 0;
            for (int i = 0; i < 9; i++)
            {
                int.TryParse(str[i], out int temp);
                bolas += temp;
            }

            switch (bolas % 9)
            {
                case 0:
                    Console.WriteLine("Rudolph");
                    break;

                case 1:
                    Console.WriteLine("Dasher");
                    break;

                case 2:
                    Console.WriteLine("Dancer");
                    break;

                case 3:
                    Console.WriteLine("Prancer");
                    break;

                case 4:
                    Console.WriteLine("Vixen");
                    break;

                case 5:
                    Console.WriteLine("Comet");
                    break;

                case 6:
                    Console.WriteLine("Cupid");
                    break;

                case 7:
                    Console.WriteLine("Donner");
                    break;

                case 8:
                    Console.WriteLine("Blitzen");
                    break;
            }
        }
    }
}