using System;

namespace uri2754
{
    internal static class Saida8
    {
        private static void Main()
        {
            const double x = 234.345, y = 45.698;
            Console.WriteLine($"{x:F6} - {y:F6}");
            Console.WriteLine($"{x:F0} - {y:F0}");
            Console.WriteLine($"{x:F1} - {y:F1}");
            Console.WriteLine($"{x:F2} - {y:F2}");
            Console.WriteLine($"{x:F3} - {y:F3}");
            Console.WriteLine($"{x:e} - {y:e}");
            Console.WriteLine($"{x:E} - {y:E}");
            Console.WriteLine($"{x:G} - {y:G}");
            Console.WriteLine($"{x:G} - {y:G}");
        }
    }
}

//using System;

//namespace uri2754
//{
//    internal static class Saida8
//    {
//        private static void Main()
//        {
//            Console.WriteLine($"234.345000 - 45.698000");
//            Console.WriteLine($"234 - 46");
//            Console.WriteLine($"234.3 - 45.7");
//            Console.WriteLine($"234.34 - 45.70");
//            Console.WriteLine($"234.345 - 45.698");
//            Console.WriteLine($"2.343450e+02 - 4.569800e+01");
//            Console.WriteLine($"2.343450E+02 - 4.569800E+01");
//            Console.WriteLine($"234.345 - 45.698");
//            Console.WriteLine($"234.345 - 45.698");
//        }
//    }
//}