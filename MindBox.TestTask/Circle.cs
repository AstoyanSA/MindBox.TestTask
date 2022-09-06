using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox.TestTask
{
    public class Circle : BaseFigure
    {
        private double square;
        private readonly double _radius;

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
                throw new ArgumentOutOfRangeException(nameof(radius));

            _radius = radius;
        }

        internal override double GetSquare()
        {
            return square = Math.PI * Math.Sqrt(_radius);
        }
    }
}
