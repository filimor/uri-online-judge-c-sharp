using System;

namespace uri1061 // Tempo de um Evento
{
    internal static class Program
    {
        private static void Main()
        {
            string[] entrada1 = Console.ReadLine().Split(' ');
            string[] entrada2 = Console.ReadLine().Split(':');
            string[] entrada3 = Console.ReadLine().Split(' ');
            string[] entrada4 = Console.ReadLine().Split(':');

            int.TryParse(entrada1[1], out int diaInicio);
            int.TryParse(entrada2[0].Trim(), out int horaInicio);
            int.TryParse(entrada2[1].Trim(), out int minutoInicio);
            int.TryParse(entrada2[2].Trim(), out int segundoInicio);
            int.TryParse(entrada3[1], out int diaTermino);
            int.TryParse(entrada4[0].Trim(), out int horaTermino);
            int.TryParse(entrada4[1].Trim(), out int minutoTermino);
            int.TryParse(entrada4[2].Trim(), out int segundoTermino);

            //24 horas = 1440 minutos = 86400 segundos

            int primeiroDia = 86400 - ((horaInicio * 3600) + (minutoInicio * 60) + segundoInicio);
            int intervaloDias = 86400 * (diaTermino - diaInicio - 1);
            int ultimoDia = (horaTermino * 3600) + (minutoTermino * 60) + segundoTermino;
            int duracaoEvento = primeiroDia + intervaloDias + ultimoDia;

            Console.WriteLine($"{duracaoEvento / 86400} dia(s)");
            Console.WriteLine($"{duracaoEvento % 86400 / 3600} hora(s)");
            Console.WriteLine($"{duracaoEvento % 86400 % 3600 / 60} minuto(s)");
            Console.WriteLine($"{duracaoEvento % 86400 % 3600 % 60} segundo(s)");
        }
    }
}