using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BapTap59
{
    class Program
    {
        static string[] Can = {"Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky"};
        static string[] Chi = {"Than", "Dau", "Tuat", "Hoi", "Ti", "Suu", "Dan", "Meo", "Thin", "Ty", "Ngo", "Mui"};

        static void Main(string[] args)
        {
            Console.Write("Nhap nam: ");
            int nam = int.Parse(Console.ReadLine());
            namAm(nam);
            Console.ReadLine();
        }

        public static void namAm(int n)
        {
            bool kt = true;
            int can = n % 10;
            int chi = n % 12;
            Console.WriteLine(n + " - " + Can[can] + " " + Chi[chi]);
            do
            {
                n++;
                if (n % 10 == can && n % 12 == chi)
                    kt = false;
            } while (kt);
            Console.WriteLine(n + " - " + Can[can] + " " + Chi[chi]);
        }
    }
}
