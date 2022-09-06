namespace MindBox.TestTask.Figures
{
    public class UnknownFigure : BaseFigure
    {
        private List<Point> Points = new List<Point>();
        public UnknownFigure(List<Point> points)
        {
            Points = points;
        }
        public override double Square
        {
            get
            {
                return GetSquare();
            }
        }

        internal override double GetSquare()
        {
            return UnknownFigureSquareCalculator.CalculateSquare(Points);
        }
    }
}