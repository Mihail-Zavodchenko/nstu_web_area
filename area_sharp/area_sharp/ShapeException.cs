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
        private string svalue;
        public ShapeException(string sv, decimal value) { svalue = sv; this.value = value; }
        public override string ToString()
        {
            return "Exception ShapeException: " + svalue + value.ToString();
        }

    }
}
