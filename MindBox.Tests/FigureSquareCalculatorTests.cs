namespace MindBox.Tests
{
    public class FigureSquareCalculatorTests
    {
        [Fact]
        public void Calculator_ShouldCalculate_CircleSquare()
        {
            double radius = 10;

            double expectedValue = Math.PI * Math.Sqrt(radius);

            //Circle circle = new Circle(radius);

            //Assert.Equal(expectedValue, circle.Square);

        }
    }
}