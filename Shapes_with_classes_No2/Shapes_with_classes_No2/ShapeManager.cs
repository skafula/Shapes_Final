using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_with_classes_No2
{
    internal class ShapeManager
    {
        public ShapeManager()
        {
            Console.Write("Add meg a csúcsok számát: ");
            if (Int32.TryParse(Console.ReadLine(), out int num))
            {
                switch (num)
                {
                    case 0:
                        Console.Write("\nAdd meg a kör sugarát: ");
                        double radius;
                        bool tryParse;
                        do
                        {
                            tryParse = double.TryParse(Console.ReadLine(), out radius);
                        } while (!tryParse);
                        Circle circle = new Circle(radius);
                        Console.WriteLine($"\n{circle.ToString()}");
                        break;
                    case 3:
                        Console.WriteLine("\nAdd meg rendre a háromszög koordinátáit (x1,y1,x2,y2,x3,y3): ");
                        Triangle triangle = new Triangle(num);
                        Console.WriteLine($"\n{triangle.ToString()}");
                        break;
                    case 4:
                        Console.WriteLine("\nAdd meg rendre a négyszüg koordinátáit (x1,y1,x2,y2,x3,y3,x4,y4): ");
                        Rectangle rectangle = new Rectangle(num);
                        Console.WriteLine($"\n{rectangle.ToString()}");
                        break;
                    default:
                        Console.WriteLine("Egyelőre csak kört(0), háromszöget(3) és négyszöget(4) tudok számolni!");
                        break;
                }
            }
            else
            {
                Console.Write("Hibás bemenet!");
            }
        }
    }
}
