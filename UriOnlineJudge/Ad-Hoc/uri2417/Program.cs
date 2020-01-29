using System;

namespace uri2417
{
    internal static class Campeonato
    {
        private static void Main()
        {
            string[] str = Console.ReadLine().Split(' ');
            int.TryParse(str[0], out int vC);
            int.TryParse(str[1], out int eC);
            int.TryParse(str[2], out int gC);
            int.TryParse(str[3], out int VF);
            int.TryParse(str[4], out int eF);
            int.TryParse(str[5], out int gF);

            int cormengo = (vC * 3) + eC;
            int flaminthians = (VF * 3) + eF;

            if (cormengo > flaminthians)
            {
                Console.WriteLine("C");
            }
            else if (flaminthians > cormengo)
            {
                Console.WriteLine("F");
            }
            else if (gC > gF)
            {
                Console.WriteLine("C");
            }
            else if (gF > gC)
            {
                Console.WriteLine("F");
            }
            else
            {
                Console.WriteLine("=");
            }
        }
    }
}