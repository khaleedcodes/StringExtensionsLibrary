using StringExtensionsLibrary;
using Xunit;


namespace StringExtensionsLibrary.Tests
{
    public class StringExtensionsTests
    {
        [Theory]
        [InlineData("Hello", true)]
        [InlineData("world", false)]
        [InlineData("123test", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void StartsWithUpper_TestCases(string input, bool expected)
        {
            bool result = input.StartsWithUpper();
            Assert.Equal(expected, result);
        }
    }
}