namespace CalculatorLibruary.CircleCalculator
{
    internal static class CircleSquareCalculator
    {
        internal static double CalculateSquare(double radius)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException($"Radius in less than 0");

            return Math.PI * Math.Sqrt(radius);
        }
    }
}
