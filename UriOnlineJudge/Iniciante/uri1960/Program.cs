using System;

namespace uri1960 // Numeração Romana para Números de Página
{
    internal static class Program
    {
        private static void Main()
        {
            string n = Console.ReadLine();
            switch (n.Length)
            {
                case 1:
                    Console.WriteLine(Romano(int.Parse(n), 'u'));
                    break;

                case 2:
                    Console.Write(Romano(int.Parse(n[0].ToString()), 'd'));
                    Console.WriteLine(Romano(int.Parse(n[1].ToString()), 'u'));
                    break;

                case 3:
                    Console.Write(Romano(int.Parse(n[0].ToString()), 'c'));
                    Console.Write(Romano(int.Parse(n[1].ToString()), 'd'));
                    Console.WriteLine(Romano(int.Parse(n[2].ToString()), 'u'));
                    break;
            }
        }

        private static string Romano(int algarismo, char posicao)
        {
            return posicao switch
            {
                'u' => algarismo switch
                {
                    1 => "I",
                    2 => "II",
                    3 => "III",
                    4 => "IV",
                    5 => "V",
                    6 => "VI",
                    7 => "VII",
                    8 => "VIII",
                    9 => "IX",
                    _ => null,
                },
                'd' => algarismo switch
                {
                    1 => "X",
                    2 => "XX",
                    3 => "XXX",
                    4 => "XL",
                    5 => "L",
                    6 => "LX",
                    7 => "LXX",
                    8 => "LXXX",
                    9 => "XC",
                    _ => null,
                },
                'c' => algarismo switch
                {
                    1 => "C",
                    2 => "CC",
                    3 => "CCC",
                    4 => "CD",
                    5 => "D",
                    6 => "DC",
                    7 => "DCC",
                    8 => "DCCC",
                    9 => "CM",
                    _ => null,
                },
                _ => null,
            };
        }

        // Pre-C# 8 function version:
        //private static string Romano(int algarismo, char posicao)
        //{
        //    switch (posicao)
        //    {
        //        case 'u':
        //            switch (algarismo)
        //            {
        //                case 1:
        //                    return "I";

        //                case 2:
        //                    return "II";

        //                case 3:
        //                    return "III";

        //                case 4:
        //                    return "IV";

        //                case 5:
        //                    return "V";

        //                case 6:
        //                    return "VI";

        //                case 7:
        //                    return "VII";

        //                case 8:
        //                    return "VIII";

        //                case 9:
        //                    return "IX";

        //                default:
        //                    return null;
        //            }
        //        case 'd':
        //            switch (algarismo)
        //            {
        //                case 1:
        //                    return "X";

        //                case 2:
        //                    return "XX";

        //                case 3:
        //                    return "XXX";

        //                case 4:
        //                    return "XL";

        //                case 5:
        //                    return "L";

        //                case 6:
        //                    return "LX";

        //                case 7:
        //                    return "LXX";

        //                case 8:
        //                    return "LXXX";

        //                case 9:
        //                    return "XC";

        //                default:
        //                    return null;
        //            }
        //        case 'c':
        //            switch (algarismo)
        //            {
        //                case 1:
        //                    return "C";

        //                case 2:
        //                    return "CC";

        //                case 3:
        //                    return "CCC";

        //                case 4:
        //                    return "CD";

        //                case 5:
        //                    return "D";

        //                case 6:
        //                    return "DC";

        //                case 7:
        //                    return "DCC";

        //                case 8:
        //                    return "DCCC";

        //                case 9:
        //                    return "CM";

        //                default:
        //                    return null;
        //            }
        //        default:
        //            return null;
        //    }
        //}
    }
}