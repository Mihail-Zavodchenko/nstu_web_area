using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_sharp
{
    class ShapeException : Exception
    {
        private decimal value;
        public ShapeException(decimal value) { this.value = value; }
        public override string ToString()
        {
            return value.ToString();
        }

    }
}
