using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    internal class CBo : CGiaSuc
    {
        public CBo() {
            Loai = 3;
        }
        public override void SinhCon()
        {
            base.SinhCon(); 
        }
        public override void Keu()
        {
            Console.WriteLine("Boo~~~~");
        }
        public override int LuongSua()
        {
            base.LuongSua();
            Random rnd = new Random();
            Sua= rnd.Next(21);
            return Sua;
        }
    }
}
