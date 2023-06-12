using Cloudculator.Core.Engines;

namespace Cloudculator.Core.UnitTests
{
    public class CalculatorEngineUnitTests
    {
        private CalculatorEngine _service;

        public CalculatorEngineUnitTests()
        {
            _service = new CalculatorEngine();
        }

        [Fact]
        public void Add_TwoNumbers_ReturnAddition()
        {
            //Arrange
            double leftArgument = 5;
            double rightArgument = 10.5;
            double expectedResult = 15.5;

            //Act
            var result = _service.Add(leftArgument, rightArgument);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Add_BothArgumentsAreMinValues_ThrowsOverflowException()
        {
            //Arrange
            var leftArgument = double.MinValue;
            var rightArgument = double.MinValue;

            //Act
            //Assert
            Assert.Throws<OverflowException>(() => _service.Add(leftArgument, rightArgument));
        }

        [Fact]
        public void Add_BothArgumentsAreMaxValues_ThrowsOverflowException()
        {
            //Arrange
            var leftArgument = double.MaxValue;
            var rightArgument = double.MaxValue;

            //Act
            //Assert
            Assert.Throws<OverflowException>(() => _service.Add(leftArgument, rightArgument));
        }

        [Fact]
        public void Add_LeftArgumentIsMaxValueRightArgumentIsMinValue_ThrowsOverflowException()
        {
            //Arrange
            var leftArgument = double.MaxValue;
            var rightArgument = double.MinValue;

            //Act
            //Assert
            Assert.Throws<OverflowException>(() => _service.Add(leftArgument, rightArgument));
        }

        [Fact]
        public void Add_BothArgumentsArePositiveInfinities_ThrowsOverflowException()
        {
            //Arrange
            var leftArgument = double.PositiveInfinity;
            var rightArgument = double.PositiveInfinity;

            //Act
            //Assert
            Assert.Throws<OverflowException>(() => _service.Add(leftArgument, rightArgument));
        }

        [Fact]
        public void Add_BothArgumentsAreNegativeInfinities_ThrowsOverflowException()
        {
            //Arrange
            var leftArgument = double.PositiveInfinity;
            var rightArgument = double.PositiveInfinity;

            //Act
            //Assert
            Assert.Throws<OverflowException>(() => _service.Add(leftArgument, rightArgument));
        }

        [Fact]
        public void Add_BothArgumentsAreNaNs_ReturnsNaN()
        {
            //Arrange
            var leftArgument = double.NaN;
            var rightArgument = double.NaN;
            var expected = double.NaN;

            //Act
            var result = _service.Add(leftArgument, rightArgument);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_LeftArgumentsIsNaNRightArgumentIsPositiveInfinity_ReturnsNaN()
        {
            //Arrange
            var leftArgument = double.NaN;
            var rightArgument = double.PositiveInfinity;
            var expected = double.NaN;

            //Act
            var result = _service.Add(leftArgument, rightArgument);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_LeftArgumentsIsPositiveInfinityArgumentIsNegativeInfinity_ReturnsNaN()
        {
            //Arrange
            var leftArgument = double.PositiveInfinity;
            var rightArgument = double.NegativeInfinity;
            var expected = double.NaN;

            //Act
            var result = _service.Add(leftArgument, rightArgument);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
