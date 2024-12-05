using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Square : Shape
    {
        public Square(int x): base(x,x) { }
        public override double Calc()
        {
            return X * X;
        }
    }

}
