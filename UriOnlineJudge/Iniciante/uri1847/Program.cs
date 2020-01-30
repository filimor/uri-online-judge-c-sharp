using System;

namespace uri1847 // Bem-vindos e Bem-vindas ao Inverno!
{
    internal static class Program
    {
        private static void Main()
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int.TryParse(entrada[0], out int a);
            int.TryParse(entrada[1], out int b);
            int.TryParse(entrada[2], out int c);

            if (b < a) //Se a temperatura desceu do 1º para o 2º dia
            {
                if (c >= b) //mas subiu ou permaneceu constante do 2º para o 3º
                {
                    Console.WriteLine(":)");
                }
                else //if (c < b) //e do 2º para o 3º
                {
                    if ((b - c) < (a - b)) //mas desceu do 2º para o 3º menos do que descera do 1º para o 2º
                    {
                        Console.WriteLine(":)");
                    }
                    else //if ((c - b) >= (b - a)) //mas desceu do 2º para o 3º no mínimo o tanto que descera do 1º para o 2º
                    {
                        Console.WriteLine(":(");
                    }
                }
            }
            else if (b > a) //Se a temperatura subiu do 1º para o 2º dia
            {
                if (c <= b) //mas desceu ou permaneceu constante do 2º para o 3º
                {
                    Console.WriteLine(":(");
                }
                else //if (c > b) //e do 2º para o 3º
                {
                    if ((c - b) < (b - a)) //mas subiu do 2º para o 3º menos do que subira do 1º para o 2º
                    {
                        Console.WriteLine(":(");
                    }
                    else //if ((c - b) >= (b - a)) //mas subiu do 2º para o 3º no mínimo o tanto que subira do 1º para o 2º
                    {
                        Console.WriteLine(":)");
                    }
                }
            }
            else if (a == b)  //Se a temperatura permaneceu constante do 1º para o 2º dia
            {
                if (c > b) //as pessoas ficam felizes se subiu do 2º para o 3º dia
                {
                    Console.WriteLine(":)");
                }
                else //
                {
                    Console.WriteLine(":(");
                }
            }
        }
    }
}