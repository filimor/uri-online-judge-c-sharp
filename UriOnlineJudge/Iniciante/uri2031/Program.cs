using System;

namespace uri2031 // Pedra, Papel, Ataque Aéreo
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            for (int i = 0; i < n; i++)
            {
                string jogada1 = Console.ReadLine();
                string jogada2 = Console.ReadLine();

                switch (jogada1)
                {
                    case "ataque":
                        switch (jogada2)
                        {
                            case "ataque":
                                Console.WriteLine("Aniquilacao mutua"); break;
                            case "pedra":
                            case "papel":
                                Console.WriteLine("Jogador 1 venceu"); break;
                        }

                        break;

                    case "pedra":
                        switch (jogada2)
                        {
                            case "ataque":
                                Console.WriteLine("Jogador 2 venceu"); break;
                            case "pedra":
                                Console.WriteLine("Sem ganhador"); break;
                            case "papel":
                                Console.WriteLine("Jogador 1 venceu"); break;
                        }
                        break;

                    case "papel":
                        switch (jogada2)
                        {
                            case "ataque":
                            case "pedra":
                                Console.WriteLine("Jogador 2 venceu"); break;
                            case "papel":
                                Console.WriteLine("Ambos venceram"); break;
                        }
                        break;
                }
            }
        }
    }
}