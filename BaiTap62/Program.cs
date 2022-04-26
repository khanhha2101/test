using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap62
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap do dai cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];

            mang = taoMang(mang, n);
            xuatMang(mang, n);

            sum(mang, n);

            capSo(mang, n);

            Console.ReadLine();
        }

        public static int[] taoMang(int[] mang, int n)
        {
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                mang[i] = rd.Next(10, 20);
            }
            return mang;
        }

        public static void xuatMang(int[] mang, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("["+i+"]:"+mang[i] + " ");
            }
        }

        public static void sum(int[] mang, int n)
        {
            int a = 0, b = 0;
            for(int i=0; i<n; i++)
            {
                if (i % 2 != 0 && mang[i] % 2 == 0)
                    a += mang[i];
                if (i % 2 == 0 && mang[i] % 2 != 0)
                    b += mang[i];
            }
            Console.Write("\nTong cac so chan o vi tri le: " + a + "\nTong cac so le o vi tri chan: " + b);
            if (a == b)
                Console.WriteLine("\n=> Bang nhau.");
            else
                Console.WriteLine("\n=> Khong bang nhau.");
        }

        public static int UCLN(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }

        public static void capSo(int[] mang, int n)
        {
            Console.WriteLine("Cac cap nguyen to cũng nhau: ");
            for (int i=0; i<n-1; i++)
            {
                for(int j = i+1; j<n; j++)
                {
                    if(i!=j)
                    {
                        int uc = UCLN(mang[i], mang[j]);
                        if (uc == 1)
                            Console.WriteLine("(" + mang[i] + ", " + mang[j] + ")");
                    }
                }
            }
        }
    }
}
