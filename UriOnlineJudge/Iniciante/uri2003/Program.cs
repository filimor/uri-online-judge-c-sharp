using System;

namespace uri2003 // Domingo de Manhã
{
    internal static class Program
    {
        private static void Main()
        {
            string str;
            while (!string.IsNullOrEmpty(str = Console.ReadLine()))
            {
                var hora = DateTime.Parse(str);
                var limite = DateTime.Parse("8:00");
                if (hora.Hour < 7)
                {
                    Console.WriteLine("Atraso maximo: 0");
                }
                else
                {
                    TimeSpan atraso = hora.AddHours(1) - limite;
                    Console.WriteLine("Atraso maximo: " + atraso.TotalMinutes);
                }
            }
        }
    }
}