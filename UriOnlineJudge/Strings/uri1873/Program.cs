using System;

namespace uri1873
{
    internal static class PedraPapelTesouraLagartoSpock
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int c);
            for (int i = 0; i < c; i++)
            {
                string resultado = string.Empty;
                string[] str = Console.ReadLine().Split(' ');

                if (str[0] == str[1])
                {
                    resultado = "empate";
                }
                else if (str[0] == "tesoura")
                {
                    resultado = str[1] == "papel" || str[1] == "lagarto" ? "rajesh" : "sheldon";
                }
                else if (str[0] == "papel")
                {
                    resultado = str[1] == "pedra" || str[1] == "spock" ? "rajesh" : "sheldon";
                }
                else if (str[0] == "pedra")
                {
                    resultado = str[1] == "lagarto" || str[1] == "tesoura" ? "rajesh" : "sheldon";
                }
                else if (str[0] == "lagarto")
                {
                    resultado = str[1] == "spock" || str[1] == "papel" ? "rajesh" : "sheldon";
                }
                else if (str[0] == "spock")
                {
                    resultado = str[1] == "tesoura" || str[1] == "pedra" ? "rajesh" : "sheldon";
                }
                else if (str[1] == "tesoura")
                {
                    resultado = str[0] == "papel" || str[0] == "lagarto" ? "rajesh" : "sheldon";
                }
                else if (str[1] == "papel")
                {
                    resultado = str[0] == "pedra" || str[0] == "spock" ? "rajesh" : "sheldon";
                }
                else if (str[1] == "pedra")
                {
                    resultado = str[0] == "lagarto" || str[0] == "tesoura" ? "rajesh" : "sheldon";
                }
                else if (str[1] == "lagarto")
                {
                    resultado = str[0] == "spock" || str[0] == "papel" ? "rajesh" : "sheldon";
                }
                else if (str[1] == "spock")
                {
                    resultado = str[0] == "tesoura" || str[0] == "pedra" ? "rajesh" : "sheldon";
                }

                Console.WriteLine(resultado);
            }
        }
    }
}

//Tesoura corta papel
//Tesoura prende lagarto

//Papel cobre pedra
//Papel refuta Spock

//Pedra derruba lagarto
//Pedra quebra tesoura

//Lagarto adormece Spock
//Lagarto come papel

//Spock derrete tesoura
//Spock vaporiza pedra