using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap65
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

            Console.Write("\n\nCac so nguyen am le: ");
            average(mang);

            Console.Write("\nMang sau khi xoa: ");
            delete(ref mang, ref n);
            xuatMang(mang, n);

            Console.ReadLine();
        }

        public static int[] taoMang(int[] mang, int n)
        {
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                mang[i] = rd.Next(-10, 10);
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

        public static void average(int[] mang)
        {
            double sum = 0;
            int dem = 0;
            foreach(int a in mang)
            {
                if(a<0 && a%2!=0)
                {
                    sum += a;
                    dem++;
                    Console.Write(a + " ");
                }
            }
            Console.WriteLine("\nTrung binh cong cac so nguyenam le la: " + (sum / dem));
        }

        public static void delete(ref int[] mang, ref int n)
        {
            int i = 1;
            while(i < n)
            {
                for (int j = 0; j < i; j++)
                {
                    if (mang[j] == mang[i])
                    {
                        for (int t = i; t<n-1; t++)
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
