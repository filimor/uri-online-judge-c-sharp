using System;

namespace uri1546 // Feedback
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            for (int i = 0; i < n; i++)
            {
                int.TryParse(Console.ReadLine(), out int k);
                for (int j = 0; j < k; j++)
                {
                    int.TryParse(Console.ReadLine(), out int f);
                    switch (f)
                    {
                        case 1:
                            Console.WriteLine("Rolien");
                            break;

                        case 2:
                            Console.WriteLine("Naej");
                            break;

                        case 3:
                            Console.WriteLine("Elehcim");
                            break;

                        case 4:
                            Console.WriteLine("Odranoel");
                            break;
                    }
                }
            }
        }
    }
}