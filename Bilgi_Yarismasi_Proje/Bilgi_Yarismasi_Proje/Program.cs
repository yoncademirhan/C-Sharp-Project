using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgi_Yarismasi_Proje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************");
            Console.WriteLine("Yarışmaya Hoşgeldiniz");
            Console.Title = "Bilgi Yarışması";
            string ad, soyad;

            Console.WriteLine("Adınız: ");
            ad= Console.ReadLine();
            Console.WriteLine("Adınız: ");
            Console.WriteLine("Soyadınız: ");
            soyad = Console.ReadLine();

            Console.WriteLine("Başlamak için enter tuşuna Basınız.");
            Console.WriteLine("Her Yanıttan Sonra Enter Tuşuna Basınız");

            Console.WriteLine("Cevapları Büyük Harflerle Veriniz");

            Console.ReadLine();

            int dogru, yanlis, para;
            dogru= 0;
            yanlis= 0;
            para= 0;

            string s1;
            Console.WriteLine("Soru 1: Cumhuriyet Kaç Yılında İlan Edilmiştir?");
            s1= Convert.ToString(Console.ReadLine());
            string c1;
            Console.WriteLine("A-1920\n B-1923\n C-1924\n D-1926\n Cevabınız: ");
            c1= Console.ReadLine();

            if(c1 == "B")
            {
                dogru++;
                para = para + 1000;
                Console.WriteLine("Tebrikler Doğru Cevap Verdiniz,Devam Etmek İçin Enter Tuşuna Basınız.");
            }
            else
            {
                yanlis++;
                Console.WriteLine("Yanlış Cevap Verdiniz,Devam Etmek İçin Enter Tuşuna Basınız");
            }


            Console.WriteLine();


            string s2;
            Console.WriteLine("Soru 2: Türkiye' nin Başkenti Neresidir ?");
            s1 = Convert.ToString(Console.ReadLine());
            string c2;
            Console.WriteLine("A-İstanbul\n B-Bayburt\n C-Ankara\n D-Van\n Cevabınız: ");
            c2 = Console.ReadLine();

            if (c2 == "C")
            {
                dogru++;
                para = para + 1000;
                Console.WriteLine("Tebrikler Doğru Cevap Verdiniz,Devam Etmek İçin Enter Tuşuna Basınız.");
            }
            else
            {
                yanlis++;
                Console.WriteLine("Yanlış Cevap Verdiniz,Devam Etmek İçin Enter Tuşuna Basınız");
            }

            Console.WriteLine();

            string s3;
            Console.WriteLine("Soru 3: Maki Hangi Bölgenin Bitki Örtüsüdür ?");
            s1 = Convert.ToString(Console.ReadLine());
            string c3;
            Console.WriteLine("A-Akdeniz\n B-Ege\n C-Kradeniz\n D-Marmara\n Cevabınız: ");
            c3 = Console.ReadLine();

            if (c3 == "A")
            {
                dogru++;
                para = para + 1000;
                Console.WriteLine("Tebrikler Doğru Cevap Verdiniz,Devam Etmek İçin Enter Tuşuna Basınız.");
            }
            else
            {
                yanlis++;
                Console.WriteLine("Yanlış Cevap Verdiniz,Devam Etmek İçin Enter Tuşuna Basınız");
            }

            Console.WriteLine();


            string s4;
            Console.WriteLine("Soru 4: Hangisi İstanbul İlçelerinden Değildir ?");
            s1 = Convert.ToString(Console.ReadLine());
            string c4;
            Console.WriteLine("A-Üsküdar\n B-Urla\n C-Kartal\n D-Pendik\n Cevabınız: ");
            c4 = Console.ReadLine();

            if (c4 == "B")
            {
                dogru++;
                para = para + 1000;
                Console.WriteLine("Tebrikler Doğru Cevap Verdiniz,Devam Etmek İçin Enter Tuşuna Basınız.");
            }
            else
            {
                yanlis++;
                Console.WriteLine("Yanlış Cevap Verdiniz,Devam Etmek İçin Enter Tuşuna Basınız");
            }

            Console.WriteLine();


            string s5;
            Console.WriteLine("Soru 5: Hangisi Programlamanın Temel Rneklerinden değildir  ?");
            s1 = Convert.ToString(Console.ReadLine());
            string c5;
            Console.WriteLine("A-Mavi\n B-Yeşil\n C-Kırmızı\n D-Sarı\n Cevabınız: ");
            c5 = Console.ReadLine();

            if (c5 == "B")
            {
                dogru++;
                para = para + 1000;
                Console.WriteLine("Tebrikler Doğru Cevap Verdiniz,Devam Etmek İçin Enter Tuşuna Basınız.");
            }
            else
            {
                yanlis++;
                Console.WriteLine("Yanlış Cevap Verdiniz,Devam Etmek İçin Enter Tuşuna Basınız");
            }


            Console.WriteLine();

            string s6;
            Console.WriteLine("Soru 6: Avrupanın Kullandığı Ortak Para Birimi Hangisidir ?");
            s6 = Convert.ToString(Console.ReadLine());
            string c6;
            Console.WriteLine("A-Dolar\n B-Euro\n C-Zloty\n D-Ruble\n Cevabınız: ");
            c6 = Console.ReadLine();

            if (c6 == "B")
            {
                dogru++;
                para = para + 1000;
                Console.WriteLine("Tebrikler Doğru Cevap Verdiniz,Devam Etmek İçin Enter Tuşuna Basınız.");
            }
            else
            {
                yanlis++;
                Console.WriteLine("Yanlış Cevap Verdiniz,Devam Etmek İçin Enter Tuşuna Basınız");
            }

            Console.WriteLine();

            string s7;
            Console.WriteLine("Soru 7: Hangi İlimiz Ege Bölgesinde Değildir ?");
            s1 = Convert.ToString(Console.ReadLine());
            string c7;
            Console.WriteLine("A-İzmir\n B-Manisa\n C-Trabzon\n D-Aydın\n Cevabınız: ");
            c7 = Console.ReadLine();

            if (c7 == "C")
            {
                dogru++;
                para = para + 1000;
                Console.WriteLine("Tebrikler Doğru Cevap Verdiniz,Devam Etmek İçin Enter Tuşuna Basınız.");
            }
            else
            {
                yanlis++;
                Console.WriteLine("Yanlış Cevap Verdiniz,Devam Etmek İçin Enter Tuşuna Basınız");
            }


            Console.WriteLine();


            string s8;
            Console.WriteLine("Soru 8: Sefiller Kitabının Yazarı Kimdir ?");
            s1 = Convert.ToString(Console.ReadLine());
            string c8;
            Console.WriteLine("A-Jules Verne\n B-Gogol\n C-Tolstoy\n D-Victor Hugo\n Cevabınız: ");
            c8 = Console.ReadLine();

            if (c8 == "D")
            {
                dogru++;
                para = para + 1000;
                Console.WriteLine("Tebrikler Doğru Cevap Verdiniz,Devam Etmek İçin Enter Tuşuna Basınız.");
            }
            else
            {
                yanlis++;
                Console.WriteLine("Yanlış Cevap Verdiniz,Devam Etmek İçin Enter Tuşuna Basınız");
            }

            Console.WriteLine();


            string s9;
            Console.WriteLine("Soru 9: Mustafa Kemal'in Nüfusa Kayıtlı Olduğu İl Hangisidir ?");
            s9 = Convert.ToString(Console.ReadLine());
            string c9;
            Console.WriteLine("A-İstanbul\n B-Bayburt\n C-Ankara\n D-Gaziantep\n Cevabınız: ");
            c9 = Console.ReadLine();

            if (c9 == "D")
            {
                dogru++;
                para = para + 1000;
                Console.WriteLine("Tebrikler Doğru Cevap Verdiniz,Devam Etmek İçin Enter Tuşuna Basınız.");
            }
            else
            {
                yanlis++;
                Console.WriteLine("Yanlış Cevap Verdiniz,Devam Etmek İçin Enter Tuşuna Basınız");
            }

            Console.WriteLine();


            string s10;
            Console.WriteLine("Soru 10: İstilal Marşı'nın Yazarı Kimdir ?");
            s10 = Convert.ToString(Console.ReadLine());
            string c10;
            Console.WriteLine("A-Mehmet Akif Ersoy\n B-Cemal Süreyya\n C-Orhan Veli\n D-Ziya Gökalp\n Cevabınız: ");
            c10 = Console.ReadLine();

            if (c10 == "A")
            {
                dogru++;
                para = para + 1000;
                Console.WriteLine("Tebrikler Doğru Cevap Verdiniz,Devam Etmek İçin Enter Tuşuna Basınız.");
            }
            else
            {
                yanlis++;
                Console.WriteLine("Yanlış Cevap Verdiniz.");
            }

            Console.WriteLine();


            Console.WriteLine("Ad Soyad:" + " " + ad + " " + soyad);
            Console.WriteLine("Doğru Sayısı: " + dogru);
            Console.WriteLine("Yanlış Sayısı: " + yanlis);
            Console.WriteLine("Kazanılan Ödül: " + para);



            Console.ReadKey();


        }
    }
}
