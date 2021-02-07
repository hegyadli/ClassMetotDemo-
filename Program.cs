using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "kerem";
            musteri1.Soyad = "koca";
            musteri1.Id = 10;
            musteri1.Yas = 19;
            musteri1.Cinsiyet = 'E';

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "taha furkan";
            musteri2.Soyad = "teke";
            musteri2.Id = 11;
            musteri2.Yas = 19;
            musteri2.Cinsiyet = 'E';

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "sadık emre";
            musteri3.Soyad = "polat";
            musteri3.Id = 12;
            musteri3.Yas = 29;
            musteri3.Cinsiyet = 'E';

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriListele(musteriler);

            Console.ReadLine();
        }
    }
}
