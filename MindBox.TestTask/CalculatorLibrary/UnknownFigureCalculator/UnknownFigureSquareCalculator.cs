namespace MindBox.TestTask.CalculatorLibrary.UnknownFigureCalculator
{
    internal class UnknownFigureSquareCalculator
    {
        //Вычисление площади многоугольника по его декартовым координатам вершин на плоскости
        internal static double CalculateSquare(List<Point> points)
        {
            double sumXToY = 0;
            double sumYToX = 0;

            for (int i = 0; i < points.Count; i++)
            {
                var j = (i + 1) % points.Count;

                //Последовательно складывается каждая координата X текущей вершины с координатой Y последующей
                sumXToY += points[i].X * points[j].Y;

                //Последовательно складывается каждая координата Y текущей вершины с координатой X последующей
                sumYToX += points[i].Y * points[j].X;
            }


            double sum = Math.Abs(sumXToY - sumYToX) / 2;

            return sum;
        }
    }
}
