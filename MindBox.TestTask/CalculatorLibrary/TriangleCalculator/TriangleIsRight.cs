namespace MindBox.TestTask.CalculatorLibrary.TriangleCalculator;

internal static class TriangleIsRight
{
    internal static bool CheckIsRigth(List<double> sides)
    {
        double maxSide = sides.Max();
        double minSide = sides.Min();
        double lastSide = sides.Find(x => x != maxSide & x != minSide);

        if (Math.Pow(maxSide, 2) - Math.Pow(minSide, 2) == Math.Pow(lastSide, 2))
        {
            return true;
        }

        return false;
    }
}
