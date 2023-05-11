using Cloudculator.Core.Engines;

namespace Cloudculator.Core.UnitTests
{
    public class CalculatorEngineUnitTests
    {
        private CalculatorEngine service;

        CalculatorEngineUnitTests()
        {
            service = new CalculatorEngine();
        }

        [Fact]
        public void Add_TwoNumbers_ReturnAddition()
        {
            //Arrange
            double leftArgument = 5;
            double rightArgument = 10.5;
            double expectedResult = 15.5;

            //Act
            var result = service.Add(leftArgument, rightArgument);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Add_AdditionOfArgumentsOverflowsDoubleMaxPrecision_ThrowsOverflowException()
        {
            //Arrange
            var leftArgument = double.MinValue;
            var rightArgument = double.MinValue;

            //Act
            //Assert
            Assert.Throws<OverflowException>(() => service.Add(leftArgument, rightArgument));
        }
    }
}
