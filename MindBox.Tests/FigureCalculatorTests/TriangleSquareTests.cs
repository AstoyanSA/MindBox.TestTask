namespace MindBox.Tests.FigureCalculatorTests;

public class TriangleSquareTests
{
    [Fact]
    public void Calculator_ShouldNotCalculate_WrongCountOfSides()
    {
        List<double> firstList = new List<double>() { };
        List<double> secondList = new List<double>() { 4 };
        List<double> thirdtList = new List<double>() { 6, 11 };
        List<double> fourthList = new List<double>() { 8, 14, 32, 7 };

        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(firstList));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(secondList));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(thirdtList));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(fourthList));
    }

    [Fact]
    public void Calculator_ShouldNotCalculate_IncorrectSide()
    {
        List<double> firstList = new List<double>() { -1, 2, 3 };
        List<double> secondList = new List<double>() { 1, -4, 12 };
        List<double> thirdtList = new List<double>() { 6, 11 };
        List<double> fourthList = new List<double>() { 0, 2, -40 };

        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(firstList));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(secondList));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(thirdtList));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(fourthList));
    }

    [Fact]
    public void Calculator_ShouldCalculate_TriangleSquare()
    {
        List<double> firstList = new List<double>() { 12, 8, 10 };

        double semiPerimeter = firstList.Sum() / 2;

        double square = Math.Sqrt(semiPerimeter * (semiPerimeter - firstList[0]) * (semiPerimeter - firstList[1]) * (semiPerimeter - firstList[2]));

        Triangle triangle = new Triangle(firstList);

        Assert.Equal(square, triangle.Square);
    }
}
