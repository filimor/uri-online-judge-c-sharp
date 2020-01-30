using System;

namespace uri1179 // Preenchimento de Vetor IV
{
    internal static class Program
    {
        private static void Main()
        {
            int[] par = new int[5];
            int[] impar = new int[5];
            int indicePar = 0, indiceImpar = 0;

            for (int i = 1; i <= 15; i++)
            {
                int.TryParse(Console.ReadLine(), out int valorLido);
                if (valorLido % 2 == 0)
                {
                    if (indicePar == 5)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            Console.WriteLine($"par[{j}] = {par[j]}");
                        }
                        indicePar = 0;
                        par[indicePar] = valorLido;
                    }
                    else
                    {
                        par[indicePar] = valorLido;
                    }
                    indicePar++;
                }
                else
                {
                    if (indiceImpar == 5)
                    {
                        for (int k = 0; k < 5; k++)
                        {
                            Console.WriteLine($"impar[{k}] = {impar[k]}");
                        }
                        indiceImpar = 0;
                        impar[indiceImpar] = valorLido;
                    }
                    else
                    {
                        impar[indiceImpar] = valorLido;
                    }
                    indiceImpar++;
                }
            }
            for (int l = 0; l < indiceImpar; l++)
            {
                Console.WriteLine($"impar[{l}] = {impar[l]}");
            }
            for (int m = 0; m < indicePar; m++)
            {
                Console.WriteLine($"par[{m}] = {par[m]}");
            }
        }
    }
}