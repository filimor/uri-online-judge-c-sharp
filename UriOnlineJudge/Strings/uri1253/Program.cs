using System;
using System.Text;

namespace uri1253
{
    internal static class CifraDeCesar
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            for (int i = 0; i < n; i++)
            {
                string cifra = Console.ReadLine();
                var sentenca = new StringBuilder(cifra.Length);

                int.TryParse(Console.ReadLine(), out int d);

                for (int j = 0; j < cifra.Length; j++)
                {
                    char c = (char)(cifra[j] - d);
                    if (c < 65)
                    {
                        c = (char)(c + 26);
                    }
                    sentenca.Append(c);
                }

                Console.WriteLine(sentenca.ToString());
            }
        }
    }
}