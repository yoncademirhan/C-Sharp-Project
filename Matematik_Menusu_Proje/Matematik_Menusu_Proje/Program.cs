using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik_Menusu_Proje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int islem;
            Console.WriteLine("Aritmetik İşlemler Menüsüne Hoşgeldiniz");
            Console.WriteLine();
            Console.WriteLine("********MENU**********\n");
            Console.WriteLine("1- Aritmetik Dört İşlem");
            Console.WriteLine("2- Üs Alma");
            Console.WriteLine("3- Kök Alma");
            Console.WriteLine("4- Karenin Çevre ve Alan Hesabı ");
            Console.WriteLine("5- Dikdörtgende alan ve Çevre Hesabı");
            Console.WriteLine("6- Eşkenar Üçgende  Çevre Hesabı\n");

            Console.WriteLine("***************\n");

            Console.Write("İşlem Yapmak İstediğiniz Alan: ");
            islem= int.Parse(Console.ReadLine());

            Console.WriteLine();

            if(islem == 1)
            {
                int a, b, toplam, fark, carpim, bolum;
                Console.Write("1. Sayıyı Giriniz: ");
                a= int.Parse(Console.ReadLine());

                Console.Write("2. Sayıyı Giriniz: ");
                b = int.Parse(Console.ReadLine());

                toplam = a + b;
                fark = a - b;
                carpim = a * b;
                bolum = a / b;

                Console.WriteLine("Toplam: " + toplam);
                Console.WriteLine("Fark: " + fark);
                Console.WriteLine("Çarpım: " + carpim);
                Console.WriteLine("Bölüm: " + bolum);
            }

            if(islem == 2)
            {
                double sayi, us, sonuc;
                Console.WriteLine("Sayıyı Giriniz:");
                sayi= double.Parse(Console.ReadLine());
                Console.WriteLine("Üs Değerini giriniz: ");
                us= double.Parse(Console.ReadLine());
                sonuc = Math.Pow(sayi, us);
                Console.WriteLine("Sonuç: " + sonuc);
            }

            if (islem == 3)
            {
                double sayi, kok;
                Console.WriteLine("Kökü Hesaplanacak Sayıyı giriniz: ");
                sayi = double.Parse(Console.ReadLine());
                kok = Math.Sqrt(sayi);
                Console.WriteLine("Sonuç: " + kok);
            }

            if(islem == 4)
            {
                int kenar, alan, cevre;
                Console.WriteLine("Kenar Değeri: ");
                kenar= int.Parse(Console.ReadLine());
                alan = kenar * kenar;
                cevre = kenar * 4;
                Console.WriteLine("Alan: " + alan);
                Console.WriteLine("Çevre: "+ cevre);
            }

            if (islem == 5)
            {
                int kisakenar, uzunkenar, cevredik, alandik;
                Console.WriteLine("Kısa Kenarı Giriniz: ");
                kisakenar= int.Parse(Console.ReadLine());
                Console.WriteLine("Uzun Kenarı Giriniz: ");
                uzunkenar = int.Parse(Console.ReadLine());

                cevredik = kisakenar + kisakenar + uzunkenar + uzunkenar;
                alandik = kisakenar * uzunkenar;

                Console.WriteLine("Alan: "+ alandik);
                Console.WriteLine("Çevre: " + cevredik);
            }

            if(islem == 6)
            {
                int kenar, cevre;
                Console.WriteLine("Kenar Değeri: ");
                kenar= int.Parse(Console.ReadLine());
                cevre = kenar * 3;
                Console.WriteLine("Çevre: " + cevre);
            }
























            Console.ReadKey();

        }
    }
}
