using laba3rpm3k2s.Factory_Method.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace laba3rpm3k2s.Abstract_Factory
{
    public class BlueFactory : IFigureFactory
    {
        public Circle CreateCircle() => new Circle
        {
            Color = Color.FromRgb(0, 0, 255)
        };
        public Square CreateSquare() => new Square
        {
            Color = Color.FromRgb(0, 0, 255)
        };
        public Triangle CreateTriangle() => new Triangle
        {
            Color = Color.FromRgb(0, 0, 255)
        };
    }
}
