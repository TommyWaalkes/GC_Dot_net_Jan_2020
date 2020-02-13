using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTesting
{
    public class PasswordVerifierTest
    {
        private PasswordVerifier pv = new PasswordVerifier();
        [Theory]
        [InlineData("Tommy1234", true)]
        [InlineData(null, false)]
        [InlineData("Tom1234", false)]
        [InlineData("tommy1234", false)]
        [InlineData("TOMMY1234", false)]
        [InlineData("TommyWaalkes", false)]
        public void TestVerify(string input, bool expected)
        {
            bool actual = pv.Verify(input);
            Assert.Equal(expected, actual);
        }
    }
}
