using System;
using System.Numerics;
using ComplexNumbers;
using Xunit;

namespace ComplexNumbersTest
{
    public class UnitTest1
    {
        private ComplexNumbers complexNumbers;

        public UnitTest1()
        {

        }

        [Fact]
        public void Addition()
        {
            Complex input = new Complex(0, 1);
            var expected = "";

            var result = revers.StringRevers(input);

            Assert.Equal(expected, result);
        }
    }
}
