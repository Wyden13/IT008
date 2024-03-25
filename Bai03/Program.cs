using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace Bai03
{
    class Program
    { 
        public static void Main(string[] args) {
            CRectangle a = new CRectangle();
            a.Nhap();
            a.CalculateArea();
            a.CalculatePerimeter();
        }
    }
}