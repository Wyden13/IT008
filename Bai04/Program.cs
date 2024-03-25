using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
namespace Bai04
{
    class Program
    {
        public static void Main(string[] args)
        {
            CDanhSanh ds = new CDanhSanh();
            ds.Nhap();
            ds.Keu();
            Console.Write("Tong luong sua gia suc: {0} ", ds.TongLuongSua());
            
        }
    }
}