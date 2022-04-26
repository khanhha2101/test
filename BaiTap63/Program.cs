using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap63
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
            Console.WriteLine("\nCac so chia het cho 4, tan cung 6: ");
            boi4(mang);

            Console.WriteLine("\nNhan doi phan tu le: ");
            nhan2(ref mang, n);

            Console.ReadLine();
        }

        public static int[] taoMang(int[] mang, int n)
        {
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                mang[i] = rd.Next(-100, 100);
            }
            return mang;
        }

        public static void xuatMang(int[] mang, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(mang[i] + " ");
            }
        }

        public static void boi4(int[] mang)
        {
            foreach(int a in mang)
            {
                if (a % 4 == 0 && a % 10 == 6)
                    Console.Write(a + " ");
            }
        }

        public static void nhan2(ref int[] mang, int n)
        {
            for(int i=0; i<n; i++)
            {
                if (mang[i] % 2 != 0)
                    mang[i] = mang[i] *2;
                Console.Write(mang[i] + " ");
            }
        }
    }
}
