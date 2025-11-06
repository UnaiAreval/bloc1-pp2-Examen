using System;

namespace Exam
{
    public class Program
    {
        public static void Main()
        {
            int num = 0;
            
            do
            {
                Console.WriteLine("Introdueix un nombre més gran que zero");
                try
                {
                    num = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Error a l'hora d'introduir el nombre");
                }
            } while (num <= 0);

            Console.WriteLine("Els nombres divisors de {0} són: ", num);
            for (int i = num; i > 0; i--)
            {
                if (num % i == 0) Console.WriteLine("   -> {0}", i);
            }
        }
    }
}