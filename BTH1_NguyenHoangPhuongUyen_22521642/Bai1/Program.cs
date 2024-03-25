using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap thang : ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam : ");
            int year = int.Parse(Console.ReadLine());

            
            int songay = 0;
            
            if(month>=1 && month <=12)
            {
                switch(month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        songay = 31;
                        break;
                    case 2: songay = 28;
                        break;
                    default: songay = 30;
                        break;

                }
            }
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                if (month == 2)
                    songay++;
            Console.WriteLine($"Thang {month} nam {year} co {songay} ngay .", month, year, songay);

        }
    }

}
