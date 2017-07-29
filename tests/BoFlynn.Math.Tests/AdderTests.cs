using System;
using Xunit;

namespace BoFlynn.Math.Tests
{
    public class AdderTests
    {
        [Fact]
        public void Add_For1Plus1_Returns2()
        {
            const int expected = 2;
            var sut = new Adder();

            var actual = sut.Add(1, 1);

            Assert.Equal(expected, actual);
        }
    }
}
