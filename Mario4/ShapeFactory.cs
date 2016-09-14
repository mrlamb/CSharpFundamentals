using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mario4
{
    class ShapeFactory
    {
        public IDrawable GetShape(Shapes shape)
        {
            switch (shape)
            {
                case Shapes.CIRCLE:
                    return new Circle();
                case Shapes.PYRAMID:
                    return new Pyramid();
                default:
                    return null;
            }
        }

        public enum Shapes
        {
            PYRAMID,
            CIRCLE
        }
    }
}
