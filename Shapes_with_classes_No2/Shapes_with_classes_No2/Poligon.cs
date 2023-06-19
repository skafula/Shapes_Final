using System.Drawing;

namespace Shapes_with_classes_No2
{
    public class Poligon : Shapes
    {
        public List<double> _sides;
        public List<Point> _pointsList;
        int _vertexCount;
        public Poligon(int vertexCount) 
        {
            _vertexCount = vertexCount;
            AddVertexes();
            CreateSides();
        }
        public void AddVertexes()
        {
            double x = 0;
            double y = 0;
            bool tryParse;
            _pointsList = new List<Point>();
            for (int i = 0; i < _vertexCount; i++)
            {
                do
                {
                    tryParse = double.TryParse(Console.ReadLine(), out x);
                    if (tryParse)
                    {
                        do
                        {
                            tryParse = double.TryParse(Console.ReadLine(), out y);
                        } while (!tryParse);
                    }
                } while (!tryParse);
                Point point = new Point(x, y);
                _pointsList.Add(point);
            }
        }
        public void CreateSides() 
        {
            _sides = new List<double>();
            for (int i =0; i < _vertexCount; i++) 
            {
                if (i < _vertexCount - 1)
                {
                    double side = Math.Sqrt(Math.Pow(_pointsList[i].X - _pointsList[i + 1].X, 2) + Math.Pow(_pointsList[i].Y - _pointsList[i + 1].Y, 2));
                    _sides.Add(side);
                }
                else
                {
                    double side = Math.Sqrt(Math.Pow(_pointsList[i].X - _pointsList[0].X, 2) + Math.Pow(_pointsList[i].Y - _pointsList[0].Y, 2));
                    _sides.Add(side);
                }
            }
        }
        public override double CalculateArea()
        { return 0.0; }
        public override double CalculatePerimeter()
        {
            double result = 0;
            foreach (double side in _sides) 
                { result += side; }
            return result;
        }
    }
}
