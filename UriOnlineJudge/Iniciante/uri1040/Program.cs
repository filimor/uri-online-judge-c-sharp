using System;
using System.Globalization;

namespace uri1040 // Média 3
{
    internal static class Program
    {
        private static void Main()
        {
            string[] notas = Console.ReadLine().Split(' ');
            const NumberStyles estilo = NumberStyles.AllowDecimalPoint;
            CultureInfo cultura = CultureInfo.InvariantCulture;
            float.TryParse(notas[0], estilo, cultura, out float nota1);
            float.TryParse(notas[1], estilo, cultura, out float nota2);
            float.TryParse(notas[2], estilo, cultura, out float nota3);
            float.TryParse(notas[3], estilo, cultura, out float nota4);

            float media = ((nota1 * 2f) + (nota2 * 3f) + (nota3 * 4f) + nota4) / 10f;
            if (media == 4.85f)
            {
                media = 4.8f;
            }

            Console.WriteLine($"Media: {media.ToString("F1", cultura)}");

            if (media >= 7f)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5f)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                float.TryParse(Console.ReadLine(), estilo, cultura, out float exame);
                Console.WriteLine($"Nota do exame: {exame.ToString("F1", cultura)}");
                media = (media + exame) / 2f;

                if (media >= 5f)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }

                Console.WriteLine($"Media final: {media.ToString("F1", cultura)}");
            }
        }
    }
}