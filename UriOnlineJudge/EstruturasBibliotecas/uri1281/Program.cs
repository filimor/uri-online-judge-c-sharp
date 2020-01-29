using System;
using System.Collections.Generic;

namespace uri1281
{
    internal static class IdaAFeira
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            for (int i = 0; i < n; i++)
            {
                double dinheiro = 0.0;

                int.TryParse(Console.ReadLine(), out int m);
                var produtos = new Dictionary<string, double>();
                for (int j = 0; j < m; j++)
                {
                    string[] strProduto = Console.ReadLine().Split(' ');
                    double.TryParse(strProduto[1], out double preco);
                    produtos.Add(strProduto[0], preco);
                }

                int.TryParse(Console.ReadLine(), out int p);
                var compras = new Dictionary<string, int>();
                for (int k = 0; k < p; k++)
                {
                    string[] strProduto = Console.ReadLine().Split(' ');
                    int.TryParse(strProduto[1], out int quantidade);
                    compras.Add(strProduto[0], quantidade);
                }

                foreach (KeyValuePair<string, int> compra in compras)
                {
                    foreach (KeyValuePair<string, double> produto in produtos)
                    {
                        if (compra.Key == produto.Key)
                        {
                            dinheiro += compra.Value * produto.Value;
                        }
                    }
                }

                Console.WriteLine($"R$ {dinheiro.ToString("F2")}");
            }
        }
    }
}