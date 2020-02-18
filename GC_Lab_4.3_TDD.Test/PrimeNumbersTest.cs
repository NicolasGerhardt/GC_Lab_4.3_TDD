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
        [InlineData(45, 197)]
        public void FindPrimeNumberByRank(int rank, int expected)
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
        [InlineData(198)]
        public void NumberIsNotPrime(int num)
        {


            bool actual = PrimeNumbers.IsPrime(num);

            Assert.False(actual);

        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(11)]
        [InlineData(197)]
        public void NumberIsPrime(int num)
        {


            bool actual = PrimeNumbers.IsPrime(num);

            Assert.True(actual);

        }

        [Theory]
        [InlineData(2, 3)]
        [InlineData(3, 5)]
        [InlineData(5, 7)]
        [InlineData(7, 11)]
        [InlineData(9, 11)]
        [InlineData(11, 13)]
        public void FindNextPrimeNumber(int number, int expected)
        {
            int actual = PrimeNumbers.Next(number);

            Assert.Equal(expected, actual);
        }

    }
}
