using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapp67
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap do dai cua mang (so chan): ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];

            mang = taoMang(mang, n);
            xuatMang(mang, n);

            Console.WriteLine("");
            

            Console.WriteLine("\n");
            Console.ReadLine();


            int  t;
            int i, j;
            
            
            for (i = 0; i < n - 1; ++i)
                for (j = i + 1; j < n; ++j)
                    if ((a[i] % 2 == 0 && a[j] % 2 == 0 && a[i] > a[j]) ||
                    (a[i] % 2 && a[j] % 2 && a[i] < a[j]))
                    { t = a[i]; a[i] = a[j]; a[j] = t; }
            
        }

        public static int[] taoMang(int[] mang, int n)
        {
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                mang[i] = rd.Next(100, 200);
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
    }
}
