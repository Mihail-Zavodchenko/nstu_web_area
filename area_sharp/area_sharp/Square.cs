using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_sharp
{
    class Square : Shape
    {
        public decimal side { get; private set; }
        public Square(decimal side)
        {
            if (side < 0)
                throw new ShapeException(side);
            this.side = side;
        }
        public override decimal CalcArea() { return side * side; }
    }
}
