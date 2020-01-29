using System;

namespace uri1047 // Tempo de Jogo com Minutos
{
    internal static class Program
    {
        private static void Main()
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int.TryParse(entrada[0], out int horaInicio);
            int.TryParse(entrada[1], out int minutoInicio);
            int.TryParse(entrada[2], out int horaTermino);
            int.TryParse(entrada[3], out int minutoTermino);

            int tempoInicio = (horaInicio * 60) + minutoInicio;
            int tempoTermino = (horaTermino * 60) + minutoTermino;
            int diferencaTempo;

            if (tempoTermino > tempoInicio) //terminou no mesmo dia
            {
                diferencaTempo = tempoTermino - tempoInicio;
                Console.WriteLine($"O JOGO DUROU {diferencaTempo / 60} HORA(S) E {diferencaTempo % 60} MINUTO(S)");
            }
            else if (tempoInicio > tempoTermino) //terminou no outro dia
            {
                diferencaTempo = 1440 - (tempoInicio - tempoTermino);
                Console.WriteLine($"O JOGO DUROU {diferencaTempo / 60} HORA(S) E {diferencaTempo % 60} MINUTO(S)");
            }
            else
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }
        }
    }
}