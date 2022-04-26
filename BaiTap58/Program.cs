using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap58
{
    class Program
    {
        /*
         viết các số nguyên từ 2 đến n. Khoanh tròn 2; gạch
        chéo tất cả những bội số khác của 2. Lặp lại bằng cách khoanh tròn số nhỏ
        nhất chưa được khoanh tròn, không bị gạch chéo; gạch chéo tất cả những
        bội số của nó. Khi không còn số nào để khoanh tròn hoặc gạch chéo thì
        dừng. Tất cả những số được khoanh tròn là số nguyên tố.
         */
        static void Main(string[] args)
        {
            Console.Write("Nhap gia tri gioi han: ");
            int a = int.Parse(Console.ReadLine());
            int n = a - 1;
            int[] mang = new int[n];

            mang = taoMang(mang, n, a);
            //xuatMang(mang);

            //Console.WriteLine("\n");

            Console.WriteLine("\n");

            Erastosthenes(mang, n);

            Console.ReadLine();
        }

        public static int[] taoMang(int[] mang, int n, int a)
        {
            int b = 2;
            for (int i = 0; i < n; i++)
            {
                mang[i] = b;
                b++;
            }
            return mang;
        }

        public static void xuatMang(int[] mang)
        {
            foreach(int a in mang)
            {
                Console.Write(a + " ");
            }
        }

        /*
         Xây dựng hàm tìm số nhỏ nhất trong số những số chưa bị gạch chéo(số gạch chéo = 0), 
        trả về số nhỏ nhất hoặc trả về 0(khi tất cả các số đều bị gạch chéo => dừng) 
             */
        public static int min(int[] mang)
        {
            foreach(int a in  mang)
            {
                if (a != 0)
                    return a;
            }
            return 0;
        }

        public static void Erastosthenes(int[] mang, int n)
        {
            while(min(mang) != 0)
            {
                int first = min(mang);
                Console.Write(first + " ");
                for(int i = 0; i < n; i++)
                {
                    if (mang[i] != 0 && mang[i] % first == 0)
                        mang[i] = 0;
                    /* first chia hết cho chính nó nên mang[i] = first = 0*/
                }
            }
        }
    }
}
