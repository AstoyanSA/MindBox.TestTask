namespace MindBox.Tests.FigureCalculatorTests
{
    public class UnknownFigureSquareTests
    {
        [Fact]
        public void Calculate_ShouldCalculate_SquareOfUnknownFigure()
        {
            List<Point> Points = new List<Point>();

            Points.AddRange(new List<Point>()
            {
                new Point(3, 4),
                new Point(5, 11),
                new Point(12, 8),
                new Point(9, 5),
                new Point(5, 6)
            });

            double ex = 30;

            UnknownFigure uk = new UnknownFigure(Points);

            Assert.Equal(ex, uk.Square);
        }
    }
}
