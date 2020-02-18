using System;
using Xunit;

namespace GC_Lab_4._3_TDD.Test
{
    public class PrimeNumbersTest
    {
        [Fact] // Black Bears are Best
        public void FirstPrimeNumber()
        {
            int rank = 1;
            int expected = 2;

            int actual = PrimeNumbers.Rank(rank);

            Assert.Equal(expected, actual);

        }

    }
}
