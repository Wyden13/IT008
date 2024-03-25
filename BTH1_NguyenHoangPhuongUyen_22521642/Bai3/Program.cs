using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so dong : ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot : ");
            int M = int.Parse(Console.ReadLine());
            int[,] a = new int[N, M];
            Nhap(a, N, M);
            //a
            Xuat(a, N, M);
            //b
            int maxelement = TheLargestElement(a, N, M);
            Console.WriteLine("Phan tu lon nhat : " + maxelement);
            //b1
            int minelement = TheSmallestElement(a, N, M);
            Console.WriteLine("Phan tu nho nhat : " + minelement);
            //c
            long largestSum = 0;
            int Dong = TheLargestSumofrow(a, N, M, ref largestSum);
            Console.WriteLine("Dong co tong lon nhat : {0} , Tong = {1} ", Dong, largestSum);
            //d
            long TongKoLaSNT = TongSoKoPhaiNguyenTo(a, N, M);
            Console.WriteLine("Tong cac so khong la so nguyen to : " + TongKoLaSNT);
            //e
        
            int nb = N;
            int mb = M;
            int[,] b = new int[nb, mb]; 
            for (int i = 0; i < nb; i++)
                for (int j = 0; j < mb; j++)
                    b[i, j] = a[i, j];
            XoaDongMatran(b,ref nb, mb);
            Xuat(b, nb,mb);
            //f
            
            int nc = N;
            int mc = M;
            int[,] c = new int[nc, mc];
            for (int i = 0; i < nc; i++)
                for (int j = 0; j < mc; j++)
                    c[i, j] = a[i, j];
            XoaCotCoPhanTuLonNhat(c, nc, ref mc);
            Xuat(c, nc, mc);
        }
        static void Nhap(int[,] a, int n, int m)
        {
            Console.Write("Nhap gioi han random : ");
            int b = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    a[i, j] = rnd.Next(b);
            }
        }
        static void Xuat(int[,] a, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(a[i, j] + " ");
                Console.WriteLine();
            }

        }
        static int TheLargestElement(int[,] a, int n, int m)
        {
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] > max)
                        max = a[i, j];
                }
            return max;
        }
        static int TheSmallestElement(int[,] a, int n, int m)
        {
            int min= int.MaxValue;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] < min)
                        min = a[i, j];
                }
            return min;
        }
        static int TheLargestSumofrow(int[,] a, int n, int m, ref long res)
        {
            //long tong = 0;
            res = long.MinValue;
            long tong;
            int dong = 0;
            for (int i = 0; i < n; i++)
            {
                tong = 0;
                for (int j = 0; j < m; j++)
                {
                    tong = tong + a[i, j];
                }
                if (tong > res)
                {
                    res = tong;
                    dong = i;
                }
            }
            return dong;
        }
        static bool SNT(int n)
        {
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) return false;
            return true;
        }
        static long TongSoKoPhaiNguyenTo(int[,]a,int n,int m)
        {
            long tong = 0;
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<m;j++)
                {
                    if (!SNT(a[i, j]))
                        tong += a[i, j];
                }
            }
            return tong;
        }
        static void XoaDongMatran(int[,] a,ref int n, int m)
        {
            Console.Write("Nhap so dong muon xoa : ");
            int k = int.Parse(Console.ReadLine());
            for(int i=k;i<n-1;i++)
            {
                for(int j=0;j<m;j++)
                {
                    a[i, j] = a[i + 1, j];
                }
            }
            --n;
        }
        static void XoaCotCoPhanTuLonNhat(int[,] a, int n, ref int m)
        {
            int max = TheLargestElement(a, n, m);
            int dong;
            int cot = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] == max)
                    {
                        cot = j;
                        break;
                    }
                }
            }
            Console.WriteLine("Cot can xoa " + cot);
            for (int i = 0; i < n; i++)
            {
                for (int j = cot; j < m-1; j++)
                {
                    a[i, j] = a[i, j + 1];
                }
            }
            --m;
        }
    }
}