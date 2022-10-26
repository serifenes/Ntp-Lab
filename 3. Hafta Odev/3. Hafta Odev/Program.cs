using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Hafta_Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            //1

            Console.WriteLine(48 / 6 / 4);
            Console.WriteLine(24 / 3 * 2);
            Console.WriteLine(2 * 2 + 5 - 1 + 4);
            Console.WriteLine((7 + 4) * 2 - 1 + 8 / 2);
            Console.WriteLine((5 - 1) * 2 - 1 + 7 * 7 / 2);

            //2
            int x = 20, y = 13, z = 42;
            Console.WriteLine(23 == 55 && 76 > 45 && 5 < 12);
            Console.WriteLine(23 >= 23 && 45 != 18);
            Console.WriteLine(x > y && z == y && x > z);

            //3
            Console.WriteLine("1. Sayıyı Giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Sayıyı Giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            if (sayi1 % sayi2 == 0) Console.WriteLine("Tam bölünüyor");
            else Console.WriteLine("Tam bölünmüyor");
            Console.ReadLine();

            //4
            String tarih = "25.04.2002";
            int ay = Convert.ToInt32(tarih.Substring(3, 2));

            ArrayList array = new ArrayList();
            array.Add("Ocak");
            array.Add("Şubat");
            array.Add("Mart");
            array.Add("Nisan");
            array.Add("Mayıs");
            array.Add("Haziran");
            array.Add("Temmuz");
            array.Add("Ağustos");
            array.Add("Eylül");
            array.Add("Ekim");
            array.Add("Kasım");
            array.Add("Aralık");

            if (ay < 10)
            {
                ay = Convert.ToInt32(ay.ToString().Substring(0, 1));
            }
            Console.WriteLine(array[ay - 1]);
            Console.ReadLine();

            //5

            Console.WriteLine("a'nın katsayısını giriniz");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b'nin katsayısını giriniz");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c'nin katsayısını giriniz");
            int c = Convert.ToInt32(Console.ReadLine());
            int delta = (int)(Math.Pow(b, 2) - 4 * a * c);
            Console.WriteLine("Kök 1: " + (-b - Math.Sqrt(delta)) / 2 * a);
            Console.WriteLine("Kök 2: " + (-b + Math.Sqrt(delta)) / 2 * a);
            Console.ReadLine();

            //6

            Console.WriteLine("Derece giriniz");
            int derece = Convert.ToInt32(Console.ReadLine());
            double radyan = derece * Math.PI / 180;
            Console.WriteLine("Radyan cinsinden " + radyan);
            Console.ReadLine();
        }
    }
}
