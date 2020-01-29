using System;
using System.Globalization;

namespace uri1761
{
    internal static class DecoracaoNatalina
    {
        private static void Main()
        {
            const double PI = 3.141592654;

            try
            {
                while (true)
                {
                    string[] entrada = Console.ReadLine().Split(' ');
                    {
                        // Ângulo calculado pelo teodolito (1.00 < A < 90.00)
                        double.TryParse(entrada[0], NumberStyles.Any, CultureInfo.InvariantCulture, out double a);
                        // Distância entre o teodolito e a árvore (1 <= B <= 100)
                        double.TryParse(entrada[1], NumberStyles.Any, CultureInfo.InvariantCulture, out double b);
                        // Altura do elfo medidor (0.50 <= C <= 1.50)
                        double.TryParse(entrada[2], NumberStyles.Any, CultureInfo.InvariantCulture, out double c);

                        double fio = 5.0 * ((Math.Tan(a * PI / 180.0) * b) + c);
                        Console.WriteLine(fio.ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch
            {
            }
#pragma warning restore CA1031 // Do not catch general exception types
        }
    }
}