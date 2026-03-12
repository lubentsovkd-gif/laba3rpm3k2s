using laba3rpm3k2s.Factory_Method.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace laba3rpm3k2s.Factory_Method.Factories.TriangleCreators
{
    public abstract class TriangleCreator
    {
        public abstract Triangle CreateTriangle();
    }
}
