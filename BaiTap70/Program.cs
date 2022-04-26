using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap70
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

            Console.WriteLine();

            sx(mang, n);

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

        public static void sx(int[] m, int n)
        {
            int tg;
            for (int i = 0; i< n-1 ; i++)
            {
                for(int j = i+1; j<n; j++)
                {
                    if(m[i]%2!=0 && m[i]<m[j])
                    {
                        tg = m[i];
                        m[i] = m[j];
                        m[j] = tg;
                    }
                    if (m[i] % 2 == 0 && m[i] > m[j])
                    {
                        tg = m[i];
                        m[i] = m[j];
                        m[j] = tg;
                    }
                }
            }
            xuatMang(m, n);
        }
    }
}
