using System;

namespace uri1134 // Tipo de Combustível
{
    internal static class Program
    {
        private static void Main()
        {
            int opcao = 0;
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (opcao != 4)
            {
                int.TryParse(Console.ReadLine(), out opcao);
                if (opcao == 1)
                {
                    alcool++;
                }
                else if (opcao == 2)
                {
                    gasolina++;
                }
                else if (opcao == 3)
                {
                    diesel++;
                }
            }
            Console.WriteLine($"MUITO OBRIGADO\nAlcool: {alcool}\nGasolina: {gasolina}\nDiesel: {diesel}");
        }
    }
}