using System;

namespace uri2533
{
    internal static class Estagio
    {
        private static void Main()
        {
            string entrada = Console.ReadLine();
            while (!string.IsNullOrEmpty(entrada))
            {
                int.TryParse(entrada, out int m);
                double[] n = new double[m];
                double[] c = new double[m];
                double numerador = 0;
                double denominador = 0;

                for (int i = 0; i < m; i++)
                {
                    string[] str = Console.ReadLine().Split(' ');
                    double.TryParse(str[0], out n[i]);
                    double.TryParse(str[1], out c[i]);
                    numerador += n[i] * c[i];
                    denominador += c[i] * 100.0;
                }

                Console.WriteLine((numerador / denominador).ToString("F4"));

                entrada = Console.ReadLine();
            }
        }
    }
}