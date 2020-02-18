using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_4._3_TDD
{
    public static class PrimeNumbers
    {
        private static List<int> primes = new List<int> { 2, 3 };

        public static int Rank(int rank)
        { 
            // convert human indexing to 
            return primes[rank - 1];
        }

        public static bool IsPrime(int num)
        {
            // make sure numer is greater than 1
            if (num <= 1)
            {
                return false;
            }
            // Check if it is already in primes list
            foreach (int prime in primes)
            {
                // if in primes list return true
                if (num == prime)
                {
                    return true;
                }
            }

            // if not in primes list
            // get floored square root of number
            int squareRoot = (int) Math.Sqrt((double) num);

            // check if it has any factors less or equal to the floored square root of number
            for (int i = 2; i <= squareRoot; i++)
            {
                // if any factors larger than 1 return false
                if (num % i == 0)
                {
                    return false;
                }
            }
            
            // else number has no factors and it prime
            return true;




        }
    }
}
