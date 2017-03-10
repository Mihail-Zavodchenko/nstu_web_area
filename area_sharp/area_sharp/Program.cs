using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Shape shape = new Square(-100);
                Console.Out.WriteLine(shape.CalcArea());
            }
            catch (ShapeException e)
            {
                Console.Out.WriteLine(e);
            }
            finally { }
        }
    }
}
