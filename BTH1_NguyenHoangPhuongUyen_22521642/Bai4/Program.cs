using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Xml.Schema;

namespace Bai4
{
    public class CPhanSo
    {
        private int tu, mau;
        public CPhanSo()
        {
            tu = 0;
            mau = 1;
        }
        public CPhanSo(int x, int y)
        {
            this.tu = x;
            this.mau = y;
        }
        public void Nhap() {
            Console.Write("Nhap tu so : ");
            this.tu = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so : ");
            this.mau = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("{0}/{1} ",tu,mau);

        }
        int gcd(int x,int y)
        {
            if (y == 0) return x;
            return gcd(y, x % y);
        }
        public CPhanSo RutGon()
        {
            int usc = gcd(tu, mau);
            this.tu = tu / usc;
            this.mau = mau / usc;
            return this;
        } 
        public static CPhanSo operator +(CPhanSo a,CPhanSo b)
        {
            CPhanSo temp = new CPhanSo();
            temp.tu = a.tu * b.mau + b.tu * a.mau;
            temp.mau = a.mau * b.mau;
            return temp;
        }
        public static CPhanSo operator -(CPhanSo a,CPhanSo b)
        {
            CPhanSo temp = new CPhanSo();
            temp.tu = a.tu * b.mau - b.tu * a.mau;
            temp.mau = a.mau * b.mau;
            return temp;
        }
        public static CPhanSo operator *(CPhanSo a,CPhanSo b)
        {
            CPhanSo temp = new CPhanSo();
            temp.tu = a.tu * b.tu;
            temp.mau = a.mau * b.mau;
            return temp;
        }
        public static CPhanSo operator /(CPhanSo a, CPhanSo b)
        {
            CPhanSo temp = new CPhanSo();
            temp.tu = a.tu * b.mau;
            temp.mau = a.mau * b.tu;
            return temp;
        }
        public override string ToString()
        {
            return $"{tu}/{mau}";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CPhanSo ps1 = new CPhanSo();
            ps1.Nhap();
            ps1.RutGon();
            ps1.Xuat();
            CPhanSo ps2 = new CPhanSo();
            CPhanSo ps3 = new CPhanSo();
            ps2.Nhap();
            ps3.Nhap();

            Console.WriteLine("{0} + {1} = " + (ps2 + ps3), ps2, ps3);

            Console.WriteLine("{0} - {1} = " + (ps2 - ps3), ps2, ps3);

            Console.WriteLine("{0} * {1} = " + (ps2 * ps3), ps2, ps3);

            Console.WriteLine("{0} / {1} = " + (ps2 / ps3), ps2, ps3);
        }
    }
}