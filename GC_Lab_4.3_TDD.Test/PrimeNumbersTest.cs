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

        [Theory] // Bears, Beets, Battlestar Galactica
        [InlineData(2, 3)]
        [InlineData(3, 5)]
        [InlineData(4, 7)]
        [InlineData(5, 11)]
        public void TestPrimeNumbers(int rank, int expected)
        {

            int actual = PrimeNumbers.Rank(rank);

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(1)]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(9)]
        public void NumberIsNotPrime(int num)
        {


            bool actual = PrimeNumbers.IsPrime(num);

            Assert.True

        }

    }
}
