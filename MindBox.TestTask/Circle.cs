using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox.TestTask
{
    public class Circle : BaseFigure
    {
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
                throw new ArgumentOutOfRangeException($"Radius in less than 0");

            _radius = radius;
        }

        internal override double GetSquare()
        {
            return Math.PI * Math.Sqrt(_radius);
        }
    }
}
