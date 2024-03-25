using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    class CRectangle : CShape
    {
        //public CRectangle() { Height = 0; Width = 0; }
        public float heigh
        {
            get { return Height; }
            set { Height = value; }
        }
        public float width
        {
            get { return Width; }
            set { Width = value; }
        }
        public void Nhap()
        {
            Console.Write("Nhap chieu dai: ");
            Height = float.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            Width = float.Parse(Console.ReadLine());
        }

        public override void CalculateArea()
        {
            this.Area = Height * Width;
            Console.WriteLine("The area of rectangle: {0} ", this.Area);
        }
        public override void CalculatePerimeter()
        {
            this.Perimeter = (Height + Width) * 2;
            Console.WriteLine("The Perimeter of rectangle: {0} ", this.Perimeter);
        }

        protected float Height; 
        protected float Width;

    }
}