using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap66
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap do dai cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];

            mang = taoMang(mang, n);
            //int n = 8;
            //int[] mang = new int[8] { -1, -1, 0, 1, 2, 4, 4, 4 };
            xuatMang(mang, n);

            Console.WriteLine("");
            int a = min(mang);
            int b = max(mang);
            Console.WriteLine("Min: "+a+"  Max: "+b);

            Console.WriteLine("");
            delete(ref mang, ref n, a, b);
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

        public static int min(int[] mang)
        {
            int min = mang[0];
            foreach (int a in mang)
            {
                if (a < min)
                    min = a;
            }
            return min;
        }

        public static int max(int[] mang)
        {
            int max = mang[0];
            foreach (int a in mang)
            {
                if (a > max)
                    max = a;
            }
            return max;
        }

        public static int getIndex(int[] mang, int n, int value)
        {
            for (int i = 0; i < n; i++)
                if (mang[i] == value)
                    return i;
            return n;
        }

        public static void delete(ref int[] mang, ref int n, int min, int max)
        {
            int indexMin = getIndex(mang, n, min);
            int indexMax = getIndex(mang, n, max);
            int i = 1;
            while (i < n)
            {
                for (int j = 0; j < i; j++)
                {
                    if (mang[j] == mang[i] && i!= indexMin && i != indexMax)
                    {
                        for (int t = i; t < n - 1; t++)
                        {
                            mang[t] = mang[t + 1];
                        }
                        n--;
                    }
                }
                i++;
            }
        }
    }
}
