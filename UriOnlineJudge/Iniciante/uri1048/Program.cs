using System;

namespace uri1048 // Aumento de Salário
{
    internal static class Program
    {
        private static void Main()
        {
            float.TryParse(Console.ReadLine(), out float salario);
            float reajuste = salario <= 400.00 ?
                0.15f : salario <= 800.00 ?
                0.12f : salario <= 1200.00 ?
                0.10f : salario <= 2000.00 ?
                0.07f : 0.04f;
            float novoSalario = salario + (salario * reajuste);

            Console.WriteLine($"Novo salario: {novoSalario.ToString("F2")}");
            Console.WriteLine($"Reajuste ganho: {(novoSalario - salario).ToString("F2")}");
            Console.WriteLine($"Em percentual: {reajuste * 100} %");
        }
    }
}