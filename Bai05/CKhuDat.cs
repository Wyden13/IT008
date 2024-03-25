using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class CKhuDat:CQuanLy
    {
        public override void Nhap()
        {

            Console.Write("Nhap dia diem khu dat: ");
            DiaDiem = Console.ReadLine();
            Console.Write("Nhap gia khu dat: ");
            Gia= long.Parse(Console.ReadLine());
            Console.Write("Nhap dien tich khu dat: ");
            DienTich=float.Parse(Console.ReadLine());   
        }
        public override void Xuat()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("Dia diem: {0}",DiaDiem);
            Console.WriteLine("Gia ban: {0} vnd", Gia);
            Console.WriteLine("Dien tich dat: {0}m^2", DienTich);
        }
        public override int isKhuDat()
        {
            return 1;
        }
        public override long TongGiaBan()
        {
            return Gia;
        }
    }
}
