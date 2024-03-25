using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
namespace Bai05
{
    class Program
    {
        public static void Main(string[] args) {
            CCongTy DaiPhu = new CCongTy();
            DaiPhu.Nhap();
            DaiPhu.Xuat();
            DaiPhu.TongGiaKhuDat();
            DaiPhu.TongGiaNhaPho();
            DaiPhu.TongGiaChungCu();
        }
    }
}