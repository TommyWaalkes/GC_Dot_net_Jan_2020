using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTesting
{
    public class PrimeFinderTest
    {
        private Primefinder pf = new Primefinder();
        [Theory]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(10)]
        public void TestEven(int input)
        {
            string expected = "even";
            string actual = pf.GetOddEvenPrime(input);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestOdd()
        {
            string expected = "odd";
            string actual = pf.GetOddEvenPrime(15);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(11)]
        [InlineData(13)]
        public void TestPrime(int input)
        {
            string expected = "prime";
            string actual = pf.GetOddEvenPrime(input);
            Assert.Equal(expected, actual);
        }
    }
}
