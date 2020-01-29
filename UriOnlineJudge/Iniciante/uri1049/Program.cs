using System;

namespace uri1049 // Animal
{
    internal static class Program
    {
        private static void Main()
        {
            string subreino = Console.ReadLine();
            string classe = Console.ReadLine();
            string alimentacao = Console.ReadLine();
            string animal = string.Empty;

            if (subreino == "vertebrado")
            {
                if (classe == "ave")
                {
                    if (alimentacao == "carnivoro")
                    {
                        animal = "aguia";
                    }
                    else if (alimentacao == "onivoro")
                    {
                        animal = "pomba";
                    }
                }
                else if (classe == "mamifero")
                {
                    if (alimentacao == "onivoro")
                    {
                        animal = "homem";
                    }
                    else if (alimentacao == "herbivoro")
                    {
                        animal = "vaca";
                    }
                }
            }
            else if (subreino == "invertebrado")
            {
                if (classe == "inseto")
                {
                    if (alimentacao == "hematofago")
                    {
                        animal = "pulga";
                    }
                    else if (alimentacao == "herbivoro")
                    {
                        animal = "lagarta";
                    }
                }
                else if (classe == "anelideo")
                {
                    if (alimentacao == "hematofago")
                    {
                        animal = "sanguessuga";
                    }
                    else if (alimentacao == "onivoro")
                    {
                        animal = "minhoca";
                    }
                }
            }

            Console.WriteLine(animal);
        }
    }
}