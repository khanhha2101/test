using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap67
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

            Console.WriteLine("");
            sapXep(ref mang, n);
            xuatMang(mang, n);

            Console.WriteLine("\n");
            chia(mang, n);
            Console.ReadLine();
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

        public static void sapXep(ref int[] mang, int n)
        {
            for(int i=0; i<n-1; i++)
            {
                int tg;
                for(int j=i+1; j<n; j++)
                {
                    if(mang[i]>mang[j])
                    {
                        tg = mang[i];
                        mang[i] = mang[j];
                        mang[j] = tg;
                    }
                }
            }
        }

        public static void chia(int[] mang, int n)
        {
            int[] mang1 = new int[n / 2];
            int[] mang2 = new int[n / 2];

            int j = 0, t=0;
            int sum1 = 0, sum2 = 0;

            for(int i=0; i<n/2-1; i++)
            {
                if (i % 2 == 0)
                {
                    mang1[j] = mang[i];
                    sum1 += mang[i];
                    j++;
                }
                else
                {
                    mang2[t] = mang[i];
                    sum2 += mang[i];
                    t++;
                }
            }
            for (int i = n/2+1; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    mang2[t] = mang[i];
                    sum2 += mang[i];
                    t++;
                }
                else
                {
                    mang1[j] = mang[i];
                    sum1 += mang[i];
                    j++;
                }
            }

            int hieu = 0;

            if ((n/2) % 2 == 0)
            {
                mang2[t] = mang[n / 2 - 1];
                t++;
                mang2[t] = mang[n / 2];
                sum2 += mang[n / 2 - 1];
                sum2 += mang[n / 2];

                hieu = Math.Abs(sum1 - sum2);
            }
            else
            {
                int hieu1 = Math.Abs((sum1 + mang[n / 2 - 1]) - (sum2 + mang[n / 2]));
                int hieu2 = Math.Abs((sum1 + mang[n / 2]) - (sum2 + mang[n / 2 - 1]));

                if (hieu1 < hieu2)
                {
                    mang1[j] = mang[n / 2 - 1];
                    mang2[t] = mang[n / 2];

                    hieu = hieu1;
                    sum1 += mang[n / 2 - 1];
                    sum2 += mang[n / 2];
                }
                else
                {
                    mang1[j] = mang[n / 2];
                    mang2[t] = mang[n / 2 - 1];

                    hieu = hieu2;
                    sum1 += mang[n / 2];
                    sum2 += mang[n / 2 - 1];
                }
            }

            foreach (int a in mang1)
            {
                Console.Write(a + " ");
            }
            Console.Write(" : " + sum1 + "\n");
            foreach (int a in mang2)
            {
                Console.Write(a + " ");
            }
            Console.Write(" : " + sum2 + "\n");
            Console.Write("\nHieu nho nhat bang: " + hieu);
        }
    }
}
