using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_with_classes_No2
{
    public class Rectangle : Poligon
    {
        public Rectangle(int vertexCount) : base(vertexCount)
        { }
        public override double CalculateArea()
        {
            return _sides[0] * _sides[1];
        }
        public bool IsSquare() => (_sides[0] - _sides[1] == 0) ? true : false;
        public override string ToString()
        {
            return $"Kerület: {this.CalculatePerimeter()}\tTerület: {this.CalculateArea()}\tNégyzet?: {this.IsSquare()}";
        }
    }
}
