using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Bai2
{
    class Program
    {
        static void Main(string[]args)
        {
            int[] a = new int[100];
            Console.Write("Nhap kich thuoc mang : ");
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            for(int i=0;i<n;i++)
            {
                a[i] = rnd.Next(int.MaxValue);
            }
            long tongle = TongLe(a, n);
            Console.WriteLine("Tong cac so le trong mang : " + tongle);
            int snt = demsnt(a, n);
            Console.WriteLine("Cac so nguyen to co trong mang : " + snt);
            int socpnn = SoChinhPhuongNhoNhat(a, n);
            Console.WriteLine("So chinh phuong nho nhat : " + socpnn);
        }
        static long TongLe(int[]a,int n)
        {
            long res = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 != 0)
                    res += a[i];
            }
            return res;
        }
        static int demsnt(int[]a,int n)
        {
            int dem = 0;
            bool flag = true;
            for(int i=  0;i<n;i++)
            {
                for(int j = 2;j * j < a[i];j++)
                {
                    if (a[i] % j == 0)
                    {
                        flag = false;
                    }
                }
                if (flag) dem++;
                flag = true;
            }
            return dem;
        }
        static bool CheckCP(int n)
        {
            int sqrt = (int)Math.Sqrt(n);
            return sqrt * sqrt == n;
        }
       
        static int SoChinhPhuongNhoNhat(int[]a,int n)
        {
            int res = int.MaxValue;
            bool check = false;
            for(int i=0;i<n;i++)
            {
                if (a[i]>=0 && CheckCP(a[i]) == true )
                {
                    check=true;
                    res = a[i] < res ? a[i] : res;
                }
            }
            if(check)
                return res;
            return -1;
        }
    }
}