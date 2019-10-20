using System;

namespace uri1192
{
    internal static class OJogoMatematicoDePaula
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                int.TryParse(str[0].ToString(), out int num1);
                string letra = str[1].ToString();
                int.TryParse(str[2].ToString(), out int num2);

                if (num1 == num2)
                {
                    Console.WriteLine(num1*num2);
                }else if(letra == letra.ToUpper())
                {
                    Console.WriteLine(num2-num1);
                }
                else
                {
                    Console.WriteLine(num1+num2);
                }
            }
        }
    }
}