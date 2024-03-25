using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class CChungCu: CQuanLy
    {
        public override void Nhap()
        {  
            Console.Write("Nhap dia diem chung cu: ");
            DiaDiem = Console.ReadLine();
            Console.Write("Nhap gia chung cu: ");
            Gia = long.Parse(Console.ReadLine());
            Console.Write("Nhap dien tich chung cu: ");
            DienTich = float.Parse(Console.ReadLine());
            Console.Write("Nhap so tang: ");
            Tang = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("Dia diem chung cu: {0}", DiaDiem);
            Console.WriteLine("Gia ban chung cu: {0} vnd", Gia);
            Console.WriteLine("Dien tich chung cu: {0}m^2", DienTich);
            Console.WriteLine("So tang: {0}", Tang);
        }
        public override int isChungCu()
        {
            return 1;
        }
        public override long TongGiaBan()
        {
            return Gia;
        }
        protected int Tang;
      
    }
}
