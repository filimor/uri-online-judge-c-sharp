using System;

namespace uri2486
{
    internal static class Program // C Mais ou Menos?
    {
        private static void Main()
        {
            string entrada;
            while ((entrada = Console.ReadLine()) != "0")
            {
                int.TryParse(entrada, out int t);
                int consumo = 0;

                for (int i = 0; i < t; i++)
                {
                    string[] str = Console.ReadLine().Split(' ');
                    int.TryParse(str[0], out int n);

                    switch (str[1])
                    {
                        case "suco":
                            consumo += n * 120;
                            break;

                        case "morango":
                        case "mamao":
                            consumo += n * 85;
                            break;

                        case "goiaba":
                            consumo += n * 70;
                            break;

                        case "manga":
                            consumo += n * 56;
                            break;

                        case "laranja":
                            consumo += n * 50;
                            break;

                        case "brocolis":
                            consumo += n * 34;
                            break;
                    }
                }

                if (consumo > 130)
                {
                    Console.WriteLine($"Menos {consumo - 130} mg");
                }
                else if (consumo < 110)
                {
                    Console.WriteLine($"Mais {110 - consumo} mg");
                }
                else
                {
                    Console.WriteLine($"{consumo} mg");
                }
            }
        }
    }
}