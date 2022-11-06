using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali_Babanin_Ciftligi_Console_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Islemler islemler= new Islemler();

            ConsoleKey islem;
            do
            {
                Console.Clear();
                Console.WriteLine("ALİBABNIN ÇİFTLİĞİ");
                Console.WriteLine("*******************");
                Console.WriteLine("A- Hayvan Ekle");
                Console.WriteLine("L- Hayvanları Listele");
                Console.WriteLine("D- Hayvan Sil");
                Console.WriteLine("I- Çiftlik İstatistiği");
                Console.WriteLine("X- Programdan Çık");
                Console.WriteLine();
                Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz:");
                islem = Console.ReadKey().Key;
                islemler.Menu(islem);
                
            } while (islem != ConsoleKey.X);

            Console.Clear();
            Console.WriteLine("Programı Kullandığınız için Teşekkür ederiz");
            Console.WriteLine("Programı Kaptmak için bir tuşa basınız.");
            Console.ReadKey();
        }
    }
}
