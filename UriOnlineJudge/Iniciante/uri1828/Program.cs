using System;

namespace uri1828 // Bazinga!
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int t);
            bool sheldon = false;
            for (int i = 1; i <= t; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                if (entrada[0] != entrada[1])
                {
                    switch (entrada[0])
                    {
                        case "pedra":
                            sheldon = entrada[1] == "lagarto" || entrada[1] == "tesoura";
                            break;

                        case "papel":
                            sheldon = entrada[1] == "pedra" || entrada[1] == "Spock";
                            break;

                        case "tesoura":
                            sheldon = entrada[1] == "papel" || entrada[1] == "lagarto";
                            break;

                        case "lagarto":
                            sheldon = entrada[1] == "Spock" || entrada[1] == "papel";
                            break;

                        case "Spock":
                            sheldon = entrada[1] == "tesoura" || entrada[1] == "pedra";
                            break;
                    }
                    Console.WriteLine($"Caso #{i}: " + (sheldon ? "Bazinga!" : "Raj trapaceou!"));
                }
                else
                {
                    Console.WriteLine($"Caso #{i}: De novo!");
                }
            }
        }
    }
}