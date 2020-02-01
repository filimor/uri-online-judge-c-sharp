// TODO Incompleto
// TODO Tentar diminuir o número de laços

using System;

namespace uri1426 // Coloque Tijolos na Parede
{
    //internal static class Program
    //{
    //    private static void Main()
    //    {
    //        int.TryParse(Console.ReadLine(), out int n);
    //        for (int i = 0; i < n; i++)
    //        {
    //            int[,] tijolos = new int[9, 9];
    //            int[,] numeros = new int[5, 5];

    //            for (int j = 0; j < 5; j++)
    //            {
    //                string[] str = Console.ReadLine().Split(' ');
    //                for (int k = 0; k < str.Length; k++)
    //                {
    //                    int.TryParse(str[j], out numeros[j, k]);
    //                }
    //            }

    //            tijolos[0, 0] = numeros[0, 0];

    //            for (int x = 2; x <= 8; x += 2)
    //            {
    //                for (int y = 0; y <= x; y += 2)
    //                {
    //                    tijolos[x, y] = numeros[x / 2, y];
    //                }
    //            }

    //            for (int x = 0; x <= 8; x += 2)
    //            {
    //                for (int y = 0; y <= x; y += 2)
    //                {
    //                    int n1 = tijolos[x, y];
    //                    int n2 = tijolos[x + 2, y];
    //                    int n3 = tijolos[x + 2, y + 2];
    //                    int c = (n1 - n2 - n3) / 2;
    //                    tijolos[x + 2, y + 1] = c;
    //                    tijolos[x + 1, y] = n2 + c; //a
    //                    tijolos[x + 1, y + 1] = n3 + c;  //b
    //                }
    //            }

    //            for (int x = 0; x <= 8; x++)
    //            {
    //                Console.WriteLine(tijolos[0, 0]);
    //                for (int y = 1; y <= x; y++)
    //                {
    //                    Console.WriteLine($" {tijolos[x, y]}");
    //                }
    //            }
    //        }
    //    }
    //}
}

// |   N1   |
// |  a  b  |
// |N2 c  N3|