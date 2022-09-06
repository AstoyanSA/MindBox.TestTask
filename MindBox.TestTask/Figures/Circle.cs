namespace MindBox.TestTask.Figures;

public class Circle : BaseFigure
{
    private readonly double _radius;
    private static Exception IncorrectRadius = new ArgumentOutOfRangeException($"Radius in less than 0");

    public override double Square
    {
        get
        {
            return GetSquare();
        }
    }

    public Circle(double radius)
    {
        if (radius < 0)
            throw IncorrectRadius;

        _radius = radius;
    }

    internal override double GetSquare()
    {
        return CircleSquareCalculator.CalculateSquare(_radius);
    }
}
