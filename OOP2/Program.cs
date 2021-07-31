using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri = new GercekMusteri();

            musteri.Id = 1;
            musteri.MusteriNo = "4444";
            musteri.Adi = "Taner";
            musteri.Soyadi = "Ürün";
            musteri.TcNo = "33333333";
            Console.WriteLine("***************************************************************************************************************");

            TuzelMusteri musteri1 = new TuzelMusteri();
            musteri1.Id = 3;
            musteri1.MusteriNo = "54321";
            musteri1.SirketAdi = "Kodlama.io";
            musteri1.VergiNo = "1234567890"; ;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri);
            musteriManager.Ekle(musteri1);



            Console.WriteLine("Hello World!");
        }
    }
}
/*
 BURADA YAPACAĞIMIZ MÜŞTERİLERİN HEM GERCEK HEMDE TÜZEL MÜŞTERİLEİRN OLMASIDIR.
BURDA BİR CLASS GERCEK MÜŞTERİLER İÇİN BİR ADET CLASS TÜZELMÜŞTERİLER İÇİN OLUŞTURULACAK.
BURADA ORTAK OLAN PROPERTİESLERDE MİRAS OLARAK TANIMALANCAK.
OLUŞTURULAN MÜŞTERİLER EKELENCEK BİR MANAGER CLASS OLUŞTURULACAK.

 
 */