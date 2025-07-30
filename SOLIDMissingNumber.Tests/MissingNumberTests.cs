using FluentAssertions;
using SOLIDMissingNumber.Implementations;
using SOLIDMissingNumber.Interfaces;

namespace SOLIDMissingNumber.Tests
{
    public class MissingNumberTests
    {
        [Theory]
        [InlineData(new int[] { 3, 0, 1 }, 2)]
        [InlineData(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }, 8)]
        public void SolutionWithArray_ReturnTheCorrectMissingNumber(int[] numbers, int expected)
        {

            IMissingNumberService target = new SolutionWithArray();


            int missingNumber = target.FindMissingNumber(numbers);


            missingNumber.Should().Be(expected);

        }


        [Theory]
        [InlineData(new int[] { 3, 0, 1 }, 2)]
        [InlineData(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }, 8)]
        public void SolutionWithLoop_ReturnTheCorrectMissingNumber(int[] numbers, int expected)
        {

            IMissingNumberService target = new SolutionWithLoop();


            int missingNumber = target.FindMissingNumber(numbers);


            missingNumber.Should().Be(expected);

        }
    }
}
