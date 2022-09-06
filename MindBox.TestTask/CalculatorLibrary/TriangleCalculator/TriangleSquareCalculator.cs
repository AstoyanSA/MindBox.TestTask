namespace MindBox.TestTask.CalculatorLibrary.TriangleCalculator
{
    internal static class TriangleSquareCalculator
    {
        internal static double CalculateSquare(List<double> sides)
        {
            if (sides.Count() != 3)
                throw Triangle.INCORRECT_COUNT;

            if (sides[0] < 0)
                throw Triangle.INCORRECT_SIDE;
            if (sides[1] < 0)
                throw Triangle.INCORRECT_SIDE;
            if (sides[2] < 0)
                throw Triangle.INCORRECT_SIDE;

            if (sides[0] + sides[1] <= sides[2]) throw Triangle.NO_TRIANGLE;
            if (sides[0] + sides[2] <= sides[1]) throw Triangle.NO_TRIANGLE;
            if (sides[1] + sides[2] <= sides[0]) throw Triangle.NO_TRIANGLE;

            double semiPerimeter = sides.Sum() / 2;

            return Math.Sqrt(semiPerimeter * (semiPerimeter - sides[0]) * (semiPerimeter - sides[1]) * (semiPerimeter - sides[2]));
        }
    }
}
