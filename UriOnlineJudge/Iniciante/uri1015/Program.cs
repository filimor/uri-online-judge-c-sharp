using System;

namespace uri1015 // Distância Entre Dois Pontos
{
    internal static class Program
    {
        private static void Main()
        {
            string[] p1 = Console.ReadLine().Split(' ');
            string[] p2 = Console.ReadLine().Split(' ');
            float.TryParse(p1[0], out float x1);
            float.TryParse(p1[1], out float y1);
            float.TryParse(p2[0], out float x2);
            float.TryParse(p2[1], out float y2);
            Console.WriteLine(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)).ToString("F4"));
        }
    }
}