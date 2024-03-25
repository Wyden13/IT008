using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    internal class CDe : CGiaSuc
    {
        public CDe() {
            Loai = 1;
        }
        public override void SinhCon()
        {
            base.SinhCon();
        }
        public override void Keu()
        {
            Console.WriteLine("De~~~~");
        }
        public override int LuongSua()
        {
            base.LuongSua();
            Random rnd = new Random();
            Sua = rnd.Next(11);
            return Sua;
        }

    }
}
