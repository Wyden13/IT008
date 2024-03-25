using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    internal class CDanhSanh
    {
        public CDanhSanh() { Soluong = 0; }
        public void Nhap() {
            int a, b, c;
            Console.Write("Nhap so luong bo: ");
            a=int.Parse(Console.ReadLine());
            Console.Write("Nhap so luong cuu: ");
            b=int.Parse(Console.ReadLine());
            Console.Write("Nhap so luong de: ");
            c=int.Parse(Console.ReadLine());

            Soluong = a + b + c;

            ds = new CGiaSuc[Soluong];
            for (int i = 0; i < a; i++)
                ds[i] = new CBo();
            for (int i = a; i < a + b; i++)
                ds[i] = new CCuu();
            for (int i = a + b; i < a + b + c; i++)
                ds[i] = new CDe();
           
        }
        public void Keu() {
            for (int i = 0; i < Soluong; i++)
                ds[i].Keu();
        }
        public int TongLuongSua() {
            int Tong = 0;
            for(int i=0;i<Soluong;i++)
            {
                Tong = Tong + ds[i].LuongSua();
            }
            return Tong;
        }

        int Soluong;
        CGiaSuc[] ds;
    }
}
