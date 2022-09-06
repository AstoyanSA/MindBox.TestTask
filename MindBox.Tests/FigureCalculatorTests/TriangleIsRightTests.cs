using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox.Tests.FigureCalculatorTests
{
    public class TriangleIsRightTests
    {
        [Fact]
        public void Calculator_ShouldCheck_TriangleIsRight()
        {
            List<double> firstList = new List<double>() { 3, 4, 5 };
            List<double> secondList = new List<double>() { 12, 8, 10 };

            Triangle firstTriangle = new Triangle(firstList);
            Triangle secondTriangle = new Triangle(secondList);

            Assert.True(firstTriangle.IsRight);
            Assert.False(secondTriangle.IsRight);
        }
    }
}
