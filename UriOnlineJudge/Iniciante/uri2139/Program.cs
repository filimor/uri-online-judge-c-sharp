using System;

namespace uri2139 // Natal de Pedrinho
{
    internal static class Program
    {
        private static void Main()
        {
            string entrada;
            while (!string.IsNullOrEmpty(entrada = Console.ReadLine()))
            {
                string[] str = entrada.Split(' ');
                int.TryParse(str[0], out int mes);
                int.TryParse(str[1], out int dia);
                if (mes == 12 && dia == 25)
                {
                    Console.WriteLine("E natal!");
                }
                else if (mes == 12 && dia > 25)
                {
                    Console.WriteLine("Ja passou!");
                }
                else if (mes == 12 && dia == 24)
                {
                    Console.WriteLine("E vespera de natal!");
                }
                else
                {
                    var d = new DateTime(2016, mes, dia);
                    var natal = new DateTime(2016, 12, 25);
                    TimeSpan t = natal.Subtract(d);
                    Console.WriteLine($"Faltam {t.TotalDays} dias para o natal!");
                }
            }
        }
    }
}