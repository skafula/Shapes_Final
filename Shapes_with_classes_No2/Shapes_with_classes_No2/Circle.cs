using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_with_classes_No2
{
    public class Circle : Shapes
    {
        double _radius;
        public Circle(double radius)
        {
            _radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }
        public override double CalculatePerimeter()
        {
            return Math.PI * 2 * _radius;
        }
        public override string ToString()
        {
            return $"Kerület: {this.CalculatePerimeter()}\tTerület: {this.CalculateArea()}";
        }
    }
}
