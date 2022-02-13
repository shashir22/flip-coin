using System;

namespace flipCoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the flip coin program");


            const int head = 0;
            const int tail = 1;

            //initilization varaibles
            int headCount = 0;
            int tailCount = 0;
            int i = 0;



            while (i <= 21)
            {

                Random random = new Random();
                int flipResult = random.Next(0, 2);
                if (flipResult == head)
                {
                    headCount++;

                }
                else
                {
                    if (flipResult == tail)

                        tailCount++;

                }
                i++;
            }
            if (head > tail)

                Console.WriteLine("Head Won by " + (headcount - tailcount));

            else if (tail > head)

                Console.WriteLine("Tail Won by " + (tailcount - headcount));

            else
            {
                Console.WriteLine("Its a Tie");
            }
            Console.ReadLine();
        }
    }
}