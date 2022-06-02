using CountSwaps;
using FluentAssertions;
using Xunit;

namespace SwapTests
{
    public class SwapTests
    {
        [Theory]
        [InlineData(6, new int[] { 5, 4, 9, 2, 1, 6 })]
        [InlineData(11, new int[] { 9, 7, 2, 6, 3, 6, 1 })]
        [InlineData(4, new int[] { 2, 8, 7, 3, 1, 9 })]
        [InlineData(0, new int[] { 1, 8, 7, 3, 1, 9 })]
        public void Should_Return_The_Expected_Number_of_Swaps(int expected, int[] array)
        {
            var actual = Swap.GetMinimumSwaps(array);

            actual.Should().Be(expected);
        }
    }
}