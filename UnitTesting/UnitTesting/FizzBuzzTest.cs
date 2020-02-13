using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTesting
{
    public class FizzBuzzTest
    {
        private FizzBuzz fb = new FizzBuzz();
        [Fact]
        public void TestFizz()
        {
            string expected = "fizz";
            string actual = fb.DoFizzBuzz(3);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestBuzz()
        {
            string expected = "buzz";
            string actual = fb.DoFizzBuzz(5);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestFizzBuzz()
        {
            string expected = "fizzbuzz";
            string actual = fb.DoFizzBuzz(15);
            Assert.Equal(expected, actual);
        }
    }
}
