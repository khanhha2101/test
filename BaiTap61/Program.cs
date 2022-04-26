using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap61
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

            Console.Write("\nNhap p [0, "+(n-1)+"]: ");
            int p = int.Parse(Console.ReadLine());

            mang = delete(mang, n, p);
            n--;
            xuatMang(mang, n);

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

        public static int sum(int[] mang)
        {
            int sum = 0;
            foreach (int a in mang)
            {
                if (a > 0)
                    sum += a;
            }
            return sum;
        }

        public static int[] delete(int[] mang, int n, int p)
        {
            for(int i=p; i<n-1; i++)
            {
                mang[i] = mang[i + 1];
            }
            return mang;
        }
    }
}
