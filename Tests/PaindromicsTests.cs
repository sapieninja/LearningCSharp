using System;

using Xunit;

namespace PaindromicNumbers
{
    public class PaindromicNumbersTests
    {
        [Theory]
        [InlineData(5, 6)]
        [InlineData(9, 11)]
        [InlineData(33, 44)]
        [InlineData(84, 88)]
        [InlineData(45653, 45654)]
        [InlineData(36460000, 36466463)]
        [InlineData(24355343, 24366342)]
        [InlineData(123450000, 123454321)]
        [InlineData(234567890, 234575432)]
        [InlineData(678999876, 679000976)]
        [InlineData(99999999999999, 100000000000001)]
        [InlineData(999999999999999, 1000000000000001)]
        [InlineData(123456789000000000, 123456789987654321)]
        [InlineData(987654321123456789, 987654322223456789)]
        [InlineData(1234567890000000000, 1234567890987654321)]
        [InlineData(9876543210123456789, 9876543211123456789)]
        [InlineData(9876543219123456789, 9876543220223456789)]
        public void TestNextPain(UInt64 input, UInt64 expected)
        {
            Assert.Equal(expected, Program.NextPain(input));
        }

    }
}