using System;

namespace flipcoin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to flip coin program");
            
            string[] coin = { "head", "tail" };

            int head = 0;

            Random random = new Random();
            int flipCoin = random.Next(0, 2);
            if (flipCoin == head)
            {
                Console.WriteLine("head");
            }
            else
            {
                Console.WriteLine("tail");
            }
            Console.ReadLine();
        }
    }
}