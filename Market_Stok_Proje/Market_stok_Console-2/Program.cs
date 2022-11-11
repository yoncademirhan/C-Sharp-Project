using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_stok_Console_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sebze = 3.25, meyve = 4.15, bakliyat = 5.50;

            double sebzestok = 1000, meyvestok = 1000, bakliyatstok = 1000;

            double sebzesatismiktari = 0, meyvesatismiktari = 0, bakliyatsatismiktari = 0;

            char anameusecim = '0', altmenusecim = '0', fiyatguncelle = '0', urunsatistipi = '0';
        //ANA MENU

        MENU:
            Console.WriteLine("Market Ürünleri Takip");
            Console.WriteLine("----------------------");
            Console.WriteLine("1- Kg Fiyat Göster");
            Console.WriteLine("2- Kg Fiyat Güncelle");
            Console.WriteLine("3- Ürün Satışı");
            Console.WriteLine("4- Stok Durumu Göster");
            Console.WriteLine("5- Toplam Satış ");
            Console.WriteLine("6- Çıkış");

            //Kullannıcya Seçim yaptırma

            Console.WriteLine("Seçimiizi Yapınız: [1,2,3,4,5,6]: ");

            anameusecim = Convert.ToChar(Console.ReadLine());

            if (anameusecim == '1')
            {
                Console.Clear();
                Console.WriteLine("-------Kg Fiyatları-------");
                Console.WriteLine("Sebze (S) : {0} TL/Kg", sebze);
                Console.WriteLine("Meyve (M) : {0} TL/Kg", meyve);
                Console.WriteLine("Bakliyat (B) : {0} TL/Kg", bakliyat);


            ALTMENU:
                Console.WriteLine("Seçiminizi Yapınız [1: Ana Menüye Dön   2: Programı Kapat]: ");
                altmenusecim = Convert.ToChar(Console.ReadLine());

                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);   //Program kapanır.
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Yaptınız");
                    goto MENU;
                }
            }
            else if (anameusecim == '2')
            {
                Console.Clear();
                Console.WriteLine("-----Kg Fiyat Güncelle----------");

            URUNTURU:
                Console.WriteLine("Ürün türünü Seçiniz [S,M,B] :");
                fiyatguncelle = Convert.ToChar(Console.ReadLine());

                if (fiyatguncelle == 'S' || fiyatguncelle == 's')
                {
                    Console.WriteLine("sebze (S): {0} Tl/Kg", sebze);
                    Console.WriteLine("Sebze için yeni fiyat giriniz: ");
                    sebze = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Fiyat Değişikliği Yapılmıştır.");
                    Console.WriteLine("Sebze (S): {0} Tl/Kg", sebze);
                }

                else if (fiyatguncelle == 'M' || fiyatguncelle == 'm')
                {
                    Console.WriteLine("Meyve (M): {0} Tl/Kg", meyve);
                    Console.WriteLine("Meyve için yeni fiyat giriniz: ");
                    sebze = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Fiyat Değişikliği Yapılmıştır.");
                    Console.WriteLine("Meyve (M): {0} Tl/Kg", meyve);
                }

                else if (fiyatguncelle == 'B' || fiyatguncelle == 'b')
                {
                    Console.WriteLine("Bakliyat (B): {0} Tl/Kg", bakliyat);
                    Console.WriteLine("Bakliyat için yeni fiyat giriniz: ");
                    sebze = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Fiyat Değişikliği Yapılmıştır.");
                    Console.WriteLine("Bakliyat (B): {0} Tl/Kg", bakliyat);
                }

                else
                {
                    Console.WriteLine("[S,M,L] dışında geçersiz seçim yaptınız.");
                    goto URUNTURU;
                }

            ALTMENU:
                Console.WriteLine("Seçiminizi Yapınız [1: Ana Menüye Dön   2: Programı Kapat]: ");
                altmenusecim = Convert.ToChar(Console.ReadLine());

                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);   //Program kapanır.
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Yaptınız");
                    goto MENU;
                }
            }

            else if (anameusecim == '3')
            {
                Console.Clear();
                Console.WriteLine("---Ürün Satışı--------");

            URUNSATIS:

                Console.WriteLine("Ürün Türünü Seçiniz [S,M,B]");
                urunsatistipi = Convert.ToChar(Console.ReadLine());

                if (urunsatistipi == 'S' || urunsatistipi == 's')
                {
                    if (sebzestok == 0)
                    {
                        Console.WriteLine("Stokta Sebze Kalmamıştır.");
                        goto MENU;
                    }
                    else
                    {
                        Console.WriteLine("Kaç Kg Sebze Almak İstersiniz: ");
                        sebzesatismiktari = Convert.ToDouble(Console.ReadLine());
                        if (sebzestok < sebzesatismiktari)
                        {
                            Console.WriteLine("Sebze Stoğunda {0} g sebze vardır , Satış Yapılamaz.");
                            goto MENU;
                        }
                        else if (sebzesatismiktari <= sebzestok)
                        {
                            sebzestok = sebzestok - sebzesatismiktari;
                            Console.WriteLine("Satış işlemi yapılmıştır.");
                            Console.WriteLine("Stokta {0} kg sebze kalmıştır.", sebzestok);
                        }
                        else
                        {
                            Console.WriteLine("[S,M,B] dışında geçersiz bir seçim yaptınız.");
                            goto URUNSATIS;
                        }
                    }
                }
                else if (urunsatistipi == 'M' || urunsatistipi == 'm')
                {
                    if (meyvestok == 0)
                    {
                        Console.WriteLine("Stokta Meyve Kalmamıştır.");
                        goto MENU;
                    }
                    else
                    {
                        Console.WriteLine("Kaç Kg Meyve Almak İstersiniz: ");
                        meyvesatismiktari = Convert.ToDouble(Console.ReadLine());
                        if (meyvestok < meyvesatismiktari)
                        {
                            Console.WriteLine("Meyve Stoğunda {0} g Meyve vardır , Satış Yapılamaz.");
                            goto MENU;
                        }
                        else if (meyvesatismiktari <= meyvestok)
                        {
                            meyvestok = meyvestok - meyvesatismiktari;
                            Console.WriteLine("Satış işlemi yapılmıştır.");
                            Console.WriteLine("Stokta {0} kg Meyve kalmıştır.", meyvestok);
                        }
                    }
                }

                else if (urunsatistipi == 'B' || urunsatistipi == 'b')
                {
                    if (bakliyatstok == 0)
                    {
                        Console.WriteLine("Stokta Bakliyat Kalmamıştır.");
                        goto MENU;
                    }
                    else
                    {
                        Console.WriteLine("Kaç Kg Bakliyat Almak İstersiniz: ");
                        bakliyatsatismiktari = Convert.ToDouble(Console.ReadLine());
                        if (bakliyatstok < bakliyatsatismiktari)
                        {
                            Console.WriteLine("Bakliyat Stoğunda {0} g Bakliyat vardır , Satış Yapılamaz.");
                            goto MENU;
                        }


                        else if (bakliyatsatismiktari <= bakliyatstok)
                        {
                            bakliyatstok = bakliyatstok - bakliyatsatismiktari;
                            Console.WriteLine("Satış işlemi yapılmıştır.");
                            Console.WriteLine("Stokta {0} kg Bakliyat kalmıştır.", bakliyatstok);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("[S,M,B] dışında geçersiz bir seçim yaptınız.");
                    goto URUNSATIS;
                }



            ALTMENU:
                Console.WriteLine("Seçiminizi Yapınız [1: Ana Menüye Dön   2: Programı Kapat]: ");
                altmenusecim = Convert.ToChar(Console.ReadLine());

                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);   //Program kapanır.
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Yaptınız");
                    goto MENU;
                }
            }

            else if (anameusecim == '4')
            {
                Console.Clear();
                Console.WriteLine("-----Stok Durumu-------");
                Console.WriteLine("Sebze Stok deposu %{0} doludur", (sebzestok / 10));
                Console.WriteLine("Meyve Stok deposu %{0} doludur", (meyvestok / 10));
                Console.WriteLine("Bakliyat Stok deposu %{0} doludur", (bakliyatstok / 10));

                Console.WriteLine();


            ALTMENU:
                Console.WriteLine("Seçiminizi Yapınız [1: Ana Menüye Dön   2: Programı Kapat]: ");
                altmenusecim = Convert.ToChar(Console.ReadLine());

                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);   //Program kapanır.
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Yaptınız");
                    goto MENU;
                }

            }

            else if (anameusecim == '5')
            {
                Console.Clear();
                Console.WriteLine("-----Toplam Satış -------");
                Console.WriteLine("Satılan Toplam Sebze Miktarı: {0} kg", sebzesatismiktari);
                Console.WriteLine("Satılan Toplam Meyve Miktarı: {0} kg",  meyvesatismiktari);
                Console.WriteLine("Satılan Toplam Bakliyat Miktarı: {0} kg", bakliyatsatismiktari);
                Console.WriteLine();

            ALTMENU:
                Console.WriteLine("Seçiminizi Yapınız [1: Ana Menüye Dön   2: Programı Kapat]: ");
                altmenusecim = Convert.ToChar(Console.ReadLine());

                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);   //Program kapanır.
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Yaptınız");
                    goto MENU;
                }

            }

            else if (anameusecim == '6')
            {
                Environment.Exit(0);
            }

        }

    }
}

