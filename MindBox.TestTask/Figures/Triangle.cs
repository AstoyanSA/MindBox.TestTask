namespace MindBox.TestTask.Figures;

public class Triangle : BaseFigure
{
    private List<double> TriangleSides = new List<double>();
    internal static Exception INCORRECT_COUNT = new ArgumentOutOfRangeException("Count of sides is not equal to 3");
    internal static Exception INCORRECT_SIDE = new ArgumentOutOfRangeException("Side can't be less than 0");
    internal static Exception NO_TRIANGLE = new ArgumentOutOfRangeException("There is no triangle with such sides");

    public Triangle(List<double> sides)
    {
        if (sides.Count != 3)
            throw INCORRECT_COUNT;

        if (sides[0] < 0)
            throw INCORRECT_SIDE;
        if (sides[1] < 0)
            throw INCORRECT_SIDE;
        if (sides[2] < 0)
            throw INCORRECT_SIDE;

        if (sides[0] + sides[1] <= sides[2]) throw NO_TRIANGLE;
        if (sides[0] + sides[2] <= sides[1]) throw NO_TRIANGLE;
        if (sides[1] + sides[2] <= sides[0]) throw NO_TRIANGLE;

        TriangleSides = sides;
    }

    public override double Square
    {
        get
        {
            return GetSquare();
        }
    }

    public bool IsRight
    {
        get
        {
            return IsRightTriangle();
        }
    }

    internal override double GetSquare()
    {

        return TriangleSquareCalculator.CalculateSquare(TriangleSides);
    }

    internal bool IsRightTriangle()
    {
        return TriangleIsRight.CheckIsRigth(TriangleSides);
    }
}
