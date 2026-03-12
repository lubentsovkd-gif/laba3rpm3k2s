using laba3rpm3k2s.Factory_Method.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace laba3rpm3k2s.Factory_Method.Factories
{
    public class GreenCircleCreator : CircleCreator
    {
        public override Circle CreateCircle() => new Circle { Color = Color.FromRgb(0, 255, 0) };
    }
}
