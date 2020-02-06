// TODO: Não passa em todos os casos de teste.

using System;

namespace uri1836 // Pokémon!
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int t);
            for (int i = 1; i <= t; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                string p = str[0];
                int.TryParse(str[1], out int l);

                str = Console.ReadLine().Split(' ');
                int.TryParse(str[0], out int bsHP);
                int.TryParse(str[1], out int ivHP);
                int.TryParse(str[2], out int evHP);
                str = Console.ReadLine().Split(' ');
                int.TryParse(str[0], out int bsAT);
                int.TryParse(str[1], out int ivAT);
                int.TryParse(str[2], out int evAT);
                str = Console.ReadLine().Split(' ');
                int.TryParse(str[0], out int bsDF);
                int.TryParse(str[1], out int ivDF);
                int.TryParse(str[2], out int evDF);
                str = Console.ReadLine().Split(' ');
                int.TryParse(str[0], out int bsSP);
                int.TryParse(str[1], out int ivSP);
                int.TryParse(str[2], out int evSP);

                int hp = (int)Math.Floor(((ivHP + bsHP + (Math.Sqrt(evHP) / 8) + 50) * l / 50) + 10);
                int at = (int)Math.Floor(((ivAT + bsAT + (Math.Sqrt(evAT) / 8)) * l / 50) + 5);
                int df = (int)Math.Floor(((ivDF + bsDF + (Math.Sqrt(evDF) / 8)) * l / 50) + 5);
                int sp = (int)Math.Floor(((ivSP + bsSP + (Math.Sqrt(evSP) / 8)) * l / 50) + 5);

                Console.WriteLine($"Caso #{i}: {p} nivel {l}");
                Console.WriteLine($"HP: {hp}");
                Console.WriteLine($"HP: {at}");
                Console.WriteLine($"HP: {df}");
                Console.WriteLine($"HP: {sp}");
            }
        }
    }
}