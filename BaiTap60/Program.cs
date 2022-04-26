using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap60
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Nhap do dai cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];
            int[] mang2 = new int[n];
            int[] mang3 = new int[n];

            mang = taoMang(mang, n);
            xuatMang(mang, n);

            Console.WriteLine("\n");

            mang2 = shuffle(mang, n);
            xuatMang(mang2, n);

            int dem = 0;
            do
            {
                mang3 = shuffle(mang2, n);
                mang2 = mang3;
                dem++;
            } while (mang.SequenceEqual(mang3) == false);
            Console.WriteLine("\nCan " + (dem+1) + " lan shuffle de mang tro ve ban dau");

            Console.ReadLine();
        }

        public static int[] taoMang(int[] mang, int n)
        {
            Random rd = new Random();
            for (int i = 0; i<n; i++)
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

        public static int[] shuffle(int[] mangA, int n)
        {
            int[] mangB = new int[n];
            int a = n / 2;
            int b = a;
            int j = 0;
            for (int i=0; i<a; i++)
            {
                mangB[j] = mangA[i];
                j++;
                mangB[j] = mangA[b];
                b++;
                j++;
            }
            return mangB;
        }
    }
}
