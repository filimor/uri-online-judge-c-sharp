using System;

namespace uri1012 // Área
{
	internal static class Program
	{
		private static void Main()
		{
			const double PI = 3.14159;
			string[] entrada = Console.ReadLine().Split(' ');
			double.TryParse(entrada[0], out double a);
			double.TryParse(entrada[1], out double b);
			double.TryParse(entrada[2], out double c);

			double triangulo = a * c / 2.0;
			double circulo = PI * c * c;
			double trapezio = (a + b) * c / 2.0;
			double quadrado = b * b;
			double retangulo = a * b;

			Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3")}\n" +
				$"CIRCULO: {circulo.ToString("F3")}\n" +
				$"TRAPEZIO: {trapezio.ToString("F3")}\n" +
				$"QUADRADO: {quadrado.ToString("F3")}\n" +
				$"RETANGULO: {retangulo.ToString("F3")}");
		}
	}
}