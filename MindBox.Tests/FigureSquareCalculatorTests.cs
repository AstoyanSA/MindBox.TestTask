namespace MindBox.Tests
{
    public class FigureSquareCalculatorTests
    {
        [Fact]
        public void Calculator_ShouldCalculate_CircleSquare()
        {
            double radius = 10;

            double expectedValue = Math.PI * Math.Sqrt(radius);

            Circle circle = new Circle(radius);

            Assert.Equal(expectedValue, circle.Square);

        }

        [Fact]
        public void Calculator_ShouldNotCalculate_CircleSquareLessThanZero()
        {
            double radius = -1;
            Exception expectedExeption = new ArgumentOutOfRangeException("Radius in less than 0");

            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius)).Equals(expectedExeption);
        }
    }
}