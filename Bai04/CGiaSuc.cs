using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    class CGiaSuc
    {
        public CGiaSuc() { Sua = 0; }
        public virtual void SinhCon() { return; }
        public virtual void Keu() { return; }
        public virtual int LuongSua() { return 0; }

        protected int Loai;
        protected int Sua;

    }
}
