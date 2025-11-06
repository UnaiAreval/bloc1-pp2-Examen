using System;

namespace Exam
{
    public class Program
    {
        public static void Main()
        {
            Random random = new Random();
            const int MaxCoins = 5;

            int lives = 3;
            int coins = 0;
            int weyWithCoin;
            int weyWithTrap;
            int weyChoised;
            bool correctValueType;

            do
            {
                do
                {
                    Console.WriteLine("You have 4 weys. Trough which one will you go? Ansuer with the number (1, 2, 3 or 4)");
                } while (false == Int32.TryParse(Console.ReadLine(), out weyChoised));

                Console.WriteLine("You have {0} coins and {1} lives", coins, lives);

                weyWithCoin = random.Next(1, 5);
                do
                {
                    weyWithTrap = random.Next(1, 5);
                } while (weyWithCoin == weyWithTrap);

                if (weyChoised == weyWithTrap) 
                {
                    Console.WriteLine("You fall in a trap");
                    lives--;
                }
                else if (weyWithCoin == weyChoised)
                {
                    Console.WriteLine("You earn a coin");
                    coins++;
                }
            } while (lives > 0 && coins != MaxCoins);
            if (coins == MaxCoins)
            {
                Console.WriteLine("You've won");
            } else
            {
                Console.WriteLine("You've lost");
            }
        }
    }
}