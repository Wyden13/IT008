using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class CNhaPho:CQuanLy
    {
        public override void Nhap()
        {
            
            Console.Write("Nhap dia diem nha pho: ");
            DiaDiem = Console.ReadLine();
            Console.Write("Nhap gia nha pho: ");
            Gia = long.Parse(Console.ReadLine());
            Console.Write("Nhap dien tich nha pho: ");
            DienTich = float.Parse(Console.ReadLine());
            Console.Write("Nhap nam xay dung: ");
            Nam= int.Parse(Console.ReadLine());
            Console.Write("Nhap so tang: ");
            Tang = int.Parse(Console.ReadLine());
        
        }
        public override void Xuat()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("Dia diem nha: {0}", DiaDiem);
            Console.WriteLine("Gia ban nha: {0} vnd", Gia);
            Console.WriteLine("Dien tich nha: {0}m^2", DienTich);
            Console.WriteLine("Nam xay dung: {0}", Nam);
            Console.WriteLine("So tang: {0}", Tang);
        }
        public override int isNhaPho()
        {
            return 1 ;
        }
        public override long TongGiaBan()
        {
            return Gia;
        }
        protected int Nam;
        protected int Tang;
    }
}
