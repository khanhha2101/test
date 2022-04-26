using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap69
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap do dai cua mang (so chan): ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];

            mang = taoMang(mang, n);
            //int n = 10;
            //int[] mang = new int[10] { 109, 111, 162, 107, 115, 111, 108, 173, 108, 113 };
            xuatMang(mang, n);

            Console.WriteLine("\n");
            run(mang, n);
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

        public static int max(int[,] mang, int n)
        {
            int max = mang[0, 1];
            for(int i = 0; i<n; i++)
            {
                if (mang[i, 1] > max)
                    max = mang[i, 1];
            }
            return max;
        }

        public static void run(int[] mang, int n)
        {
            int[,] rs = new int[n, 2];
            int t = 0;
            for(int i=0; i<n-1; i++)
            {
                if(mang[i] < mang[i+1])
                {
                    int j = i, dem = 1;
                    while (j < n - 1)
                    {
                        if (mang[j] < mang[j + 1])
                            dem++;
                        else
                            break;
                        j++;
                    }
                    rs[t, 0] = i;
                    rs[t, 1] = dem;
                    t++;
                }
            }

            int sl = max(rs, t);
            int vt = 0;
            for (int i = 0; i< t; i++)
            {
                if (rs[i, 1] == sl)
                {
                    vt = rs[i, 0];
                }
            }
            Console.Write("");
            for(int i=1; i<=sl; i++)
            {
                Console.Write(mang[vt] + " ");
                vt++;
            }
        }
    }
}
