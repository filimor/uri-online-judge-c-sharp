using System;

namespace uri1197
{
	internal static class VoltaAFaculdadeDeFisica
	{
		private static void Main()
		{
			try
			{
				while (true)
				{
					string[] entrada = Console.ReadLine().Split(' ');
					int.TryParse(entrada[0], out int v);
					int.TryParse(entrada[1], out int t);
					Console.WriteLine(v*t*2);
				}
			}
#pragma warning disable CA1031 // Do not catch general exception types
#pragma warning disable RCS1075 // Avoid empty catch clause that catches System.Exception.
			catch (Exception)
#pragma warning restore RCS1075 // Avoid empty catch clause that catches System.Exception.
			{
			}
#pragma warning restore CA1031 // Do not catch general exception types
		}
	}
}
