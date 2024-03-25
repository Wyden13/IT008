using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    abstract class CShape
    {
        
        public virtual void CalculateArea() { return; }
        public virtual void CalculatePerimeter() { return; }

        protected float Area;
        protected float Perimeter;
    }
}
