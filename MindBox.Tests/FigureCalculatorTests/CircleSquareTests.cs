namespace MindBox.Tests.FigureCalculatorTests;

public class CircleSquareTests
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
    public void Calculator_ShouldNotCalculate_CircleRadiusIsLessThanZero()
    {
        double radius = -1;

        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
    }
}