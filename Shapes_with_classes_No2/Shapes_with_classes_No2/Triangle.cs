using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_with_classes_No2
{
    public class Triangle : Poligon
    {
        public Triangle(int vertexCount) : base(vertexCount) 
        { }
        public override double CalculateArea()
        { 
            return Math.Abs((_pointsList[0].X * (_pointsList[1].Y - _pointsList[2].Y) + _pointsList[1].X * (_pointsList[2].Y - _pointsList[0].Y)
                                + _pointsList[2].X * (_pointsList[0].Y - _pointsList[1].Y)) / 2);
        }
        public bool IsRegular() => (_sides[0] == _sides[1] && _sides[1] == _sides[2]) ? true : false;
        public bool IsIsosceles() => (_sides[0] == _sides[1] || _sides[1] == _sides[2] || _sides[0] == _sides[2]) ? true : false;
        public override string ToString()
        {
            return $"Kerület: {this.CalculatePerimeter()}\tTerület: {this.CalculateArea()}\tSzabályos?: {this.IsRegular()}\tEgyenlő szárú?: {this.IsIsosceles()}";
        }
    }
}
