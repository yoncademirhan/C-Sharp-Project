using System;
using System.Collections.Generic;

namespace Ali_Babanin_Ciftligi_Console_3
{
    public class Islemler
    {
        private List<Kedi> Kediler = new List<Kedi>();
        private List<Kopek> Kopekler = new List<Kopek>();
        private List<Koyun> Koyunlar = new List<Koyun>();
        private List<Tavuk> Tavuklar = new List<Tavuk>();
        private List<Ayi> Ayilar = new List<Ayi>();

        public void Menu(ConsoleKey key)
        {
            Console.Clear();
            switch (key)
            {
                case ConsoleKey.A:
                    Ekle();
                    break;
                case ConsoleKey.L:
                    Listele();
                    break;
                case ConsoleKey.D:
                    Sil();
                    break;
                case ConsoleKey.I:
                    Isttistik();
                    break;
            }
        }

        private void Isttistik()
        {
            
            int toplam = Tavuklar.Count + Koyunlar.Count + Kediler.Count + Kopekler.Count + Ayilar.Count;

            Baslik("HAYVAN İSTATİSTİK");
            Console.WriteLine("Tavuk Sayısı: " + Tavuklar.Count);
            Console.WriteLine("Koyun Sayısı: " + Koyunlar.Count);
            Console.WriteLine("Kedi Sayısı: " + Kediler.Count);
            Console.WriteLine("Köpek Sayısı: " + Kopekler.Count);
            Console.WriteLine("Ayı Sayısı: " + Ayilar.Count);

            int toplamElSayisi = 0;
            int toplamAyakSayisi = 0;

            foreach(var canli in Kediler)
            {
                toplamElSayisi += canli.El;
                toplamAyakSayisi += canli.Ayak;
            }
            foreach (var canli in Kopekler)
            {
                toplamElSayisi += canli.El;
                toplamAyakSayisi += canli.Ayak;
            }
            foreach (var canli in Tavuklar)
            {
                toplamElSayisi += canli.El;
                toplamAyakSayisi += canli.Ayak;
            }
            foreach (var canli in Ayilar)
            {
                toplamElSayisi += canli.El;
                toplamAyakSayisi += canli.Ayak;
            }
            foreach (var canli in Koyunlar)
            {
                toplamElSayisi += canli.El;
                toplamAyakSayisi += canli.Ayak;
            }

            Console.WriteLine("Toplam Hayvan Sayısı: " + toplam);
            Console.WriteLine("Toplam El Sayısı: " + toplamElSayisi);
            Console.WriteLine("Toplam Ayak Sayısı: " + toplamAyakSayisi);

            Anamenu("");

        }

        private void Sil()
        {
            Baslik("hAYVAN SİL");
            int toplam = Tavuklar.Count + Koyunlar.Count + Kediler.Count + Kopekler.Count + Ayilar.Count;

            if (toplam > 0)
            {
                Console.WriteLine("Hangi Hayvan Türünü Silmek İstersiniz? ");
                if (Tavuklar.Count > 0)
                {
                    Console.WriteLine("\t1 - Tavuk");
                }
                if (Kediler.Count > 0)
                {
                    Console.WriteLine("\t1 - Kedi");
                }
                if (Koyunlar.Count > 0)
                {
                    Console.WriteLine("\t1 - Koyun");
                }
                if (Kopekler.Count > 0)
                {
                    Console.WriteLine("\t1 - Köpek");
                }
                if (Ayilar.Count > 0)
                {
                    Console.WriteLine("\t1 - Ayı");
                }

                Console.WriteLine();
                Console.Write("Silmek İstediğiniz türün numarasını giriniz:");
                char tur = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.WriteLine("Kaç adet ?");
                int adet = int.Parse(Console.ReadLine());
                string mesaj = String.Empty;

                switch (tur)
                {
                    case '1':
                        Tavuklar.RemoveRange(0, adet);
                        mesaj = "Tavuk";
                        break;
                    case '2':
                        Kediler.RemoveRange(0, adet);
                        mesaj = "Kedi";
                        break;
                    case '3':
                        Koyunlar.RemoveRange(0, adet);
                        mesaj = "Koyun";
                        break;
                    case '4':
                        Kopekler.RemoveRange(0, adet);
                        mesaj = "Köpek";
                        break;
                    case '5':
                        Ayilar.RemoveRange(0, adet);
                        mesaj = "Ayı";
                        break;
                }

                Anamenu($"toplam {adet} adet {mesaj} silinmiştir.");
            }
            else
            {
                Anamenu("Silinecek Hayvan Bulunamadı");
            }
        }

        private void Listele()
        {
            Baslik("HAYVANLARI LİSTELE");
            int toplam = Tavuklar.Count + Koyunlar.Count + Kediler.Count + Kopekler.Count + Ayilar.Count;

            if (toplam > 0)
            {
                Console.WriteLine("Tavuk Sayısı: " + Tavuklar.Count);
                Console.WriteLine("Koyun Sayısı: " + Koyunlar.Count);
                Console.WriteLine("Kedi Sayısı: " + Kediler.Count);
                Console.WriteLine("Köpek Sayısı: " + Kopekler.Count);
                Console.WriteLine("Ayı Sayısı: " + Ayilar.Count);
            }
            else
            {
                Anamenu("Listelenecek Hayvan Bulunamadı");
            }
        }



        private void Ekle()
        {
            Baslik("HAYVAN EKLE");

            Console.WriteLine("Hangi Hayvan türünü Eklemek İstersiniz? ");
            Console.WriteLine("\t1- Tavuk");
            Console.WriteLine("\t2- Kedi");
            Console.WriteLine("\t3- Koyun");
            Console.WriteLine("\t4- Köpek");
            Console.WriteLine("\t5- Ayı");
            Console.WriteLine();
            Console.Write("Eklemek istediğiiz türün numarasını giriniz: ");
            char tur = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.Write("Kaç Adet?");
            int adet = int.Parse(Console.ReadLine());

            switch (tur)
            {
                case '1':
                    for (int i = 0; i < adet; i++)
                    {
                        Tavuklar.Add(new Tavuk() { El = 0, Ayak = 2 });
                    }
                    break;
                case '2':
                    for (int i = 0; i < adet; i++)
                    {
                        Kediler.Add(new Kedi() { El = 0, Ayak = 4 });
                    }
                    break;
                case '3':
                    for (int i = 0; i < adet; i++)
                    {
                        Koyunlar.Add(new Koyun() { El = 0, Ayak = 4 });
                    }
                    break;
                case '4':
                    for (int i = 0; i < adet; i++)
                    {
                        Kopekler.Add(new Kopek() { El = 0, Ayak = 4 });
                    }
                    break;
                case '5':
                    for (int i = 0; i < adet; i++)
                    {
                        Ayilar.Add(new Ayi() { El = 2, Ayak = 2 });
                    }
                    break;
            }
            Anamenu("Ekleme İşlemi başarı İle tamamlanmıştır.");
        }




        private void Baslik(string v)
        {
            Console.WriteLine(v);
            Console.WriteLine("---------------------");
            Console.WriteLine();

        }


        private void Anamenu(string v)
        {
            Console.WriteLine(v);
            Console.WriteLine("ana Menüye Dönmek İçin Bir Tuşa Basınız.");
            Console.ReadKey();
        }

    }
}
