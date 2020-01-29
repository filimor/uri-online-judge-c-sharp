using System;

namespace uri1118 // Várias Notas Com Validação
{
    internal static class Program
    {
        private static void Main()
        {
            int opcao;
            do
            {
                double.TryParse(Console.ReadLine(), out double nota1);
                while ((nota1 < 0) || (nota1 > 10))
                {
                    Console.WriteLine("nota invalida");
                    double.TryParse(Console.ReadLine(), out nota1);
                }
                double.TryParse(Console.ReadLine(), out double nota2);
                while ((nota2 < 0) || (nota2 > 10))
                {
                    Console.WriteLine("nota invalida");
                    double.TryParse(Console.ReadLine(), out nota2);
                }
                Console.WriteLine($"media = {((nota1 + nota2) / 2.0).ToString("F2")}");
                do
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    int.TryParse(Console.ReadLine(), out opcao);
                } while ((opcao != 1) && (opcao != 2));
            } while (opcao != 2);
        }
    }
}