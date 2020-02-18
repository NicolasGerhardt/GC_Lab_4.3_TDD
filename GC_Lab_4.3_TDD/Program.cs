using System;

namespace GC_Lab_4._3_TDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let’s locate some primes!");
            Console.WriteLine();
            Console.WriteLine("This application will find you any prime, in order, from first prime number on.");
            
            do
            {
                Console.WriteLine();
                Console.Write("Which prime number are you looking for?: ");
                int rank = int.Parse(Console.ReadLine());
                Console.WriteLine();

                int prime = PrimeNumbers.Rank(rank);

                Console.WriteLine($"The number {rank} prime is {prime}.");
                Console.WriteLine();

            } while (Continue());
        }

        private static bool Continue()
        {
            while (true)
            {
                Console.Write("Do you want to find another prime number? (y / n)");
                ConsoleKey key = Console.ReadKey(true).Key;
                Console.WriteLine();

                if (key == ConsoleKey.Y)
                {
                    return true;
                }
                else if (key == ConsoleKey.N)
                {
                    return false;
                }
            }

        }
    }
}
