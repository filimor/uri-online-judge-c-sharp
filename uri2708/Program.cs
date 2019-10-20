using System;

namespace uri2708
{
    internal static class TuristasNoParqueHuacachina
    {
        private static void Main()
        {
            int turistas = 0;
            int veiculos = 0;
            string[] str = Console.ReadLine().Split(' ');

            while (str[0] != "ABEND")
            {
                if (str[0] == "SALIDA")
                {
                    veiculos++;
                    turistas += int.Parse(str[1]);
                }
                else
                {
                    veiculos--;
                    turistas -= int.Parse(str[1]);
                }
                str = Console.ReadLine().Split(' ');
            }

            Console.WriteLine(turistas);
            Console.WriteLine(veiculos);
        }
    }
}