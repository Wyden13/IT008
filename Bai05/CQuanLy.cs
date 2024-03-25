using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal abstract class CQuanLy
    {
       
        public virtual void Nhap() { return; }
        public virtual void Xuat() { return; }
        public virtual long TongGiaBan() { return 0; }

        public virtual int isKhuDat() { return 0; }
        public virtual int isChungCu() { return 0; }
        public virtual int isNhaPho() { return 0; }

        protected string DiaDiem;
        protected long Gia;
        protected float DienTich;
    }
}
