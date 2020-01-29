using System;

namespace uri2295 // Frota de Táxi
{
    internal static class Program
    {
        private static void Main()
        {
            string[] str = Console.ReadLine().Split(' ');
            float.TryParse(str[0], out float a);
            float.TryParse(str[1], out float g);
            float.TryParse(str[2], out float ra);
            float.TryParse(str[3], out float rg);
            Console.WriteLine((g / rg <= a / ra) ? "G" : "A");
        }
    }
}