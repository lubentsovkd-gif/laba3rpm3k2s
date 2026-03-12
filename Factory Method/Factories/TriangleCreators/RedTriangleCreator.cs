using laba3rpm3k2s.Factory_Method.Factories.SquareCreators;
using laba3rpm3k2s.Factory_Method.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace laba3rpm3k2s.Factory_Method.Factories.TriangleCreators
{
    public class RedTriangleCreator : TriangleCreator
    {
        public override Triangle CreateTriangle() => new Triangle { Color = Color.FromRgb(255, 0, 0) };
    }
}
