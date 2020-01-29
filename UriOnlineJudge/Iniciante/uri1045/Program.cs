using System;

namespace uri1045 // Tipos de Triângulos
{
	internal static class Program
	{
		private static void Main()
		{
			string[] entrada = Console.ReadLine().Split(' ');
			double.TryParse(entrada[0], out double lado1);
			double.TryParse(entrada[1], out double lado2);
			double.TryParse(entrada[2], out double lado3);
			double a, b, c;

			//verifica o maior lado
			if ((lado1 > lado2) && (lado1 > lado3))
			{
				a = lado1;
				if (lado2 > lado3)
				{
					b = lado2;
					c = lado3;
				}
				else
				{
					c = lado2;
					b = lado3;
				}
			}
			else if ((lado2 > lado1) && (lado2 > lado3))
			{
				a = lado2;
				if (lado1 > lado3)
				{
					b = lado1;
					c = lado3;
				}
				else
				{
					c = lado1;
					b = lado3;
				}
			}
			else
			{
				a = lado3;
				if (lado1 > lado2)
				{
					b = lado1;
					c = lado2;
				}
				else
				{
					c = lado1;
					b = lado2;
				}
			}

			//classifica o triângulo
			if (a >= b + c)
			{
				Console.WriteLine("NAO FORMA TRIANGULO");
			}
			else
			{
				if (a * a == (b * b) + (c * c))
				{
					Console.WriteLine("TRIANGULO RETANGULO");
				}
				else if (a * a > (b * b) + (c * c))
				{
					Console.WriteLine("TRIANGULO OBTUSANGULO");
				}
				else if (a * a < (b * b) + (c * c))
				{
					Console.WriteLine("TRIANGULO ACUTANGULO");
				}

				if ((a == b) && (b == c))
				{
					Console.WriteLine("TRIANGULO EQUILATERO");
				}
				else if ((a == b) ^ (b == c))
				{
					Console.WriteLine("TRIANGULO ISOSCELES");
				}
			}
		}
	}
}