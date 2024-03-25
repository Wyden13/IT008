using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    internal class CCuu: CGiaSuc
    {
        public CCuu()
        {
            Loai = 2;
        }
        public override void SinhCon()
        {
            base.SinhCon();
        }
        public override void Keu()
        {
            Console.WriteLine("Be Be");
        }
        public override int LuongSua()
        {
            base.LuongSua();
            Random rnd = new Random();
            Sua = rnd.Next(6);
            return Sua;
        }

    }
}
