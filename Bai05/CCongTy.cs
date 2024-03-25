using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class CCongTy
    {
        public void Nhap()
        {
            Console.Write("Nhap so luong thong tin can quan ly: ");
            n = int.Parse(Console.ReadLine());
            ds = new CQuanLy[n];
            for(int i=0;i<n;i++)
            {
                int loai;
                Console.Write("(1.Khu dat|2.Nha pho|3.Chung cu): ");
                loai= int.Parse(Console.ReadLine());
                switch(loai) {
                    case 1:
                        ds[i] = new CKhuDat();
                        break;
                    case 2:
                        ds[i] = new CNhaPho();
                        break;
                    case 3:
                        ds[i] = new CChungCu();
                        break;
                }
                ds[i].Nhap();
            }
        }
        public void Xuat()
        {
            for (int i = 0; i < n; i++)
                ds[i].Xuat();
        }

        public void TongGiaKhuDat()
        {
            long Tong = 0;
            for (int i = 0; i < n; i++)
                if (ds[i].isKhuDat() == 1)
                    Tong += ds[i].TongGiaBan();
            Console.WriteLine("Tong gia ban cua khu dat: {0}", Tong);
        }
        public void TongGiaChungCu()
        {
            long Tong = 0;
            for (int i = 0; i < n; i++)
                if (ds[i].isChungCu() == 1)
                    Tong += ds[i].TongGiaBan();
            Console.WriteLine("Tong gia ban cua nha pho: {0}", Tong);
        }
        public void TongGiaNhaPho()
        {
            long Tong = 0;
            for (int i = 0; i < n; i++)
                if (ds[i].isNhaPho() == 1)
                    Tong += ds[i].TongGiaBan();
            Console.WriteLine("Tong gia ban cua chung cu: {0}", Tong);
        }

        int n;
        CQuanLy[] ds;
    }
}
