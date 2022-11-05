using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akaryakit_Proje_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////DEĞİŞKEN TANIMLAMALARI
            double dizel = 3.12, benzin = 3.28, lpg = 1.78;     //birim fiyatları

            double dizeltank = 1000, benzintank = 1000, lpgtank = 1000;  //tankların kapasitesi

            double satismiktari = 0;  //satışı yapılan miktar

            char anamenusecim = '0', altmenusecim = '0', akaryakitfiyatguncelle = '0', akaryakitsatistipi = '0';   //menü seçimlerini tutmak için 


        //ANA MENU OLUŞLTURMA

        MENU:
            Console.WriteLine("Akaryakıt Satış Takip");
            Console.WriteLine("---------------------");
            Console.WriteLine("1- Birim Fiyat Göster");
            Console.WriteLine("2- Birim Fyat Güncelle");
            Console.WriteLine("3- Akaryakıt Satışı Yap");
            Console.WriteLine("4- Depo Durumunu Göster");
            Console.WriteLine("5- Toplam Satışları Göster");
            Console.WriteLine("6- Çıkış");

            //KULLANICIYA SEÇİM YAPTIRMA

            Console.Write("Seçiminiz Yapınız [1,2,3,4,5,6]: ");

            anamenusecim = Convert.ToChar(Console.ReadLine());   //console dan girilen tüm degerler stringdir. Bizden istenen char deger oldugu için stringten char a dönüşüm yapıldı.

            if (anamenusecim == '1')
            {
                Console.Clear();    //console ekranı temizlenir.
                Console.WriteLine(">> Seçiminiz: 1");
                Console.WriteLine("---Birim Fiyatlar listesi---");    //yakıtların birim fiyatları listelenir.
                Console.WriteLine("Dizel (D) : {0} TL/Litre", dizel);
                Console.WriteLine("Benzin (B) : {0} TL/Litre", benzin);
                Console.WriteLine("LPG (L) : {0} TL/Litre", lpg);

            ALTMENU:
                Console.WriteLine("Seçiminizi Yapınız [1: Ana Menüye Dön 2: Programı Kapat]: ");
                altmenusecim = Convert.ToChar(Console.ReadLine());

                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;   //MENU ye gider.
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);   //Programın kapatılmasını sağlar.
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Yaptınız");
                    goto ALTMENU;   // Tekrar seçim yapması için altmenu ye gönderilir.
                }

            }
            else if (anamenusecim == '2')     //ANAMENU de 2. seçim yapılıyıor
            {
                Console.Clear();
                Console.WriteLine(">> Seçiminiz: 2");
                Console.WriteLine("--- Birim Fiyatlar Güncelleme--- ");

            AKARYAKITTIPI:
                Console.WriteLine("Akaryakıt Tipini Seçiniz [D, B, L]");
                akaryakitfiyatguncelle = Convert.ToChar(Console.ReadLine());   //Kullanıcdan gelen string deger char a dönüştürülüyor.

                if (akaryakitfiyatguncelle == 'D' || akaryakitfiyatguncelle == 'd')
                {
                    Console.WriteLine("dizel (D):{0} TL/Litre", dizel);        //Güncel olan fişyat yazdırılır.
                    Console.Write("Dizel Yakıt İçin Yeni Fiyat Griniz: ");
                    dizel = Convert.ToDouble(Console.ReadLine());      //Kullanıcının girdiği deger double dönüştürüldü.
                    Console.WriteLine("Değişiklik yapılmıştır.");
                    Console.WriteLine("Dizel (D):{0} TL/Litre", dizel);   //dizel yakıtın yeni fiyatı ile güncelleme yapıldı.
                }


                else if (akaryakitfiyatguncelle == 'B' || akaryakitfiyatguncelle == 'b')
                {
                    Console.WriteLine("Benzin (B):{0} TL/Litre", benzin);        //Güncel olan fiyat yazdırılır.
                    Console.Write("Benzin Yakıt İçin Yeni Fiyat Griniz: ");
                    dizel = Convert.ToDouble(Console.ReadLine());      //Kullanıcının girdiği deger double dönüştürüldü.
                    Console.WriteLine("Değişiklik yapılmıştır.");
                    Console.WriteLine("Benzin (B):{0} TL/Litre", benzin);   //benzin yakıtın yeni fiyatı ile güncelleme yapıldı.
                }


                else if (akaryakitfiyatguncelle == 'L' || akaryakitfiyatguncelle == 'l')
                {
                    Console.WriteLine("LPG (B):{0} TL/Litre", lpg);        //Güncel olan fiyat yazdırılır.
                    Console.Write("LPG Yakıt İçin Yeni Fiyat Griniz: ");
                    dizel = Convert.ToDouble(Console.ReadLine());      //Kullanıcının girdiği deger double dönüştürüldü.
                    Console.WriteLine("Değişiklik yapılmıştır.");
                    Console.WriteLine("LPG (B):{0} TL/Litre", lpg);   //LPG yakıtın yeni fiyatı ile güncelleme yapıldı.
                }

                else
                {
                    Console.WriteLine("[D,B,L] dışında hatalı seçim yaptınız!");
                    goto AKARYAKITTIPI;
                }


            ALTMENU:
                Console.WriteLine("Seçiminizi Yapınız [1: Ana Menüye Dön 2: Programı Kapat]: ");
                altmenusecim = Convert.ToChar(Console.ReadLine());

                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;   //MENU ye gider.
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);   //Programın kapatılmasını sağlar.
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Yaptınız");
                    goto ALTMENU;   // Tekrar seçim yapması için altmenu ye gönderilir.
                }

            }

            else if (anamenusecim == '3')
            {
                Console.Clear();
                Console.WriteLine(">>Seçiminiz: 3");
                Console.WriteLine("---Akaryakıt Satış İşlemi---");

            AKARYAKITSATISI:
                Console.WriteLine("Akaryakıt Tipini Seçin [D,B,L]");
                akaryakitsatistipi = Convert.ToChar(Console.ReadLine());
                if (akaryakitsatistipi == 'D' || akaryakitsatistipi == 'd')
                {
                    if (dizeltank == 0)       //Tank boş ise;
                    {
                        Console.WriteLine("Yakıt tankında dizel yakıt kalmamıştır.");
                        goto MENU;
                    }
                    else
                    {
                        Console.WriteLine("Ne kadarlık Dizel Yakıt Alacaksınız");
                        satismiktari = Convert.ToDouble(Console.ReadLine());
                        if (dizeltank < satismiktari)            //satış miktarı tanktaki yakıttan fazla ise;
                        {
                            Console.WriteLine("Yakıt tankında {0} litre dizel yakıt vardır ! İşlem yapılamdı", dizeltank);
                            goto MENU;
                        }
                        else if (satismiktari <= dizeltank)   //satış miktarı tanktaki yakıta eşit veya az ise;
                        {
                            dizeltank = dizeltank - satismiktari;
                            Console.WriteLine("Yakıt dolumu tamamlanmıştır");
                            Console.WriteLine("Yakıt tankında {0} litre dizel yakıt kaldı. ", dizeltank);
                        }
                    }
                }

                else if (akaryakitsatistipi == 'B' || akaryakitsatistipi == 'b')
                {
                    if (benzintank == 0)       //Tank boş ise;
                    {
                        Console.WriteLine("Yakıt tankında benzin yakıt kalmamıştır.");
                        goto MENU;
                    }
                    else
                    {
                        Console.WriteLine("Ne kadarlık benzin Yakıt Alacaksınız");
                        satismiktari = Convert.ToDouble(Console.ReadLine());
                        if (benzintank < satismiktari)            //satış miktarı tanktaki yakıttan fazla ise;
                        {
                            Console.WriteLine("Yakıt tankında {0} litre benzin yakıt vardır ! İşlem yapılamdı", benzintank);
                            goto MENU;
                        }
                        else if (satismiktari <= benzintank)   //satış miktarı tanktaki yakıta eşit veya az ise;
                        {
                            benzintank = benzintank - satismiktari;
                            Console.WriteLine("Yakıt dolumu tamamlanmıştır");
                            Console.WriteLine("Yakıt tankında {0} litre benzin yakıt kaldı. ", benzintank);
                        }
                    }
                }

                else if (akaryakitsatistipi == 'L' || akaryakitsatistipi == 'l')
                {
                    if (lpgtank == 0)       //Tank boş ise;
                    {
                        Console.WriteLine("Yakıt tankında LPG yakıt kalmamıştır.");
                        goto MENU;
                    }
                    else
                    {
                        Console.WriteLine("Ne kadarlık LPG Yakıt Alacaksınız");
                        satismiktari = Convert.ToDouble(Console.ReadLine());
                        if (lpgtank < satismiktari)            //satış miktarı tanktaki yakıttan fazla ise;
                        {
                            Console.WriteLine("Yakıt tankında {0} litre LPG yakıt vardır ! İşlem yapılamdı", lpgtank);
                            goto MENU;
                        }
                        else if (satismiktari <= lpgtank)   //satış miktarı tanktaki yakıta eşit veya az ise;
                        {
                            lpgtank = lpgtank - satismiktari;
                            Console.WriteLine("Yakıt dolumu tamamlanmıştır");
                            Console.WriteLine("Yakıt tankında {0} litre LPG yakıt kaldı. ", lpgtank);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("[D,B,L] dışında hatalı seçim yaptınız!");
                    goto AKARYAKITSATISI;
                }

            ALTMENU:
                Console.WriteLine("Seçiminizi Yapınız [1: Ana Menüye Dön 2: Programı Kapat]: ");
                altmenusecim = Convert.ToChar(Console.ReadLine());

                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;   //MENU ye gider.
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);   //Programın kapatılmasını sağlar.
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Yaptınız");
                    goto ALTMENU;   // Tekrar seçim yapması için altmenu ye gönderilir.
                }

            }
            else if (anamenusecim == '4')
            {
                Console.Clear();
                Console.WriteLine(">> Seçiminiz: 4");
                Console.WriteLine("---Depo Durumu---");
                Console.WriteLine("Dizel Yakıt Tankı %{0} doludur.", (dizeltank / 10));    //Yakıt miktarları gösterilir.
                Console.WriteLine("Benzin Yakıt Tankı %{0} doludur.", (benzintank / 10));
                Console.WriteLine("Lpg Yakıt Tankı %{0} doludur.", (lpgtank / 10));

                Console.WriteLine();

            ALTMENU:
                Console.WriteLine("Seçiminizi Yapınız [1: Ana Menüye Dön 2: Programı Kapat]: ");
                altmenusecim = Convert.ToChar(Console.ReadLine());

                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;   //MENU ye gider.
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);   //Programın kapatılmasını sağlar.
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Yaptınız");
                    goto ALTMENU;   // Tekrar seçim yapması için altmenu ye gönderilir.
                }

            }

            else if (anamenusecim == '5')
            {
                Console.Clear();
                Console.WriteLine(">> Seçiminiz: 5");
                Console.WriteLine("---Toplam Satış Durumu---");
                Console.WriteLine("Satılan Toplam Dizel Yakıt:{0}", 1000 - dizeltank);   //satıln miktar hesaplanır.
                Console.WriteLine("Dizel Yakıt tutarı:{0}", (1000 - dizeltank) * dizel);
                Console.WriteLine("Satılan Toplam Benzin Yakıt:{0}", 1000 - benzintank);
                Console.WriteLine("Benzin Yakıt tutarı:{0}", (1000 - benzintank) * benczin);
                Console.WriteLine("Satılan Toplam LPG Yakıt:{0}", 1000 - lpgtank);
                Console.WriteLine("LPG Yakıt tutarı:{0}", (1000 - lpgtank) * lpg);

                Console.WriteLine("__________________________________");
                Console.WriteLine("Toplam Tutar:{0}", ((1000 - dizeltank) * dizel) + ((1000 - benzintank) * benzin) + ((1000 - lpgtank) * lpg));

                Console.WriteLine();

            ALTMENU:
                Console.WriteLine("Seçiminizi Yapınız [1: Ana Menüye Dön 2: Programı Kapat]: ");
                altmenusecim = Convert.ToChar(Console.ReadLine());

                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;   //MENU ye gider.
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);   //Programın kapatılmasını sağlar.
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Yaptınız");
                    goto ALTMENU;   // Tekrar seçim yapması için altmenu ye gönderilir.
                }

            }

            else if (anamenusecim == '6')
            {
                Environment.Exit(0);        //Uygulamnın kapatılması sağlanır.

            }


            Console.ReadKey();
        }
    }
}
