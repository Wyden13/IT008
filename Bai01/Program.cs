using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.IO;
namespace Bai1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap duong dan thu muc: ");
            string strFile = Console.ReadLine();
            if (Directory.Exists(strFile))
            {
                string[] str = Directory.GetFiles(strFile);
                if (str.Length != 0)
                {
                    Console.WriteLine();
                    for (int i = 0; i < str.Length; i++)
                        Console.WriteLine(str[i]);
                }
                else
                    Console.Write("Khong co tap tin nao trong thu muc");
            }
            else
                Console.WriteLine("Thu muc khong ton tai");
            Console.ReadLine();
        }
    }
}
