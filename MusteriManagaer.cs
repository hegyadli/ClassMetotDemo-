using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Musteri eklendi: " + musteri.Ad + " " + musteri.Soyad + " " + musteri.Id + " " + musteri.Yas + " " + musteri.Cinsiyet + "\n--------\n");
        }
        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad + " " + musteri.Soyad);
            }
            Console.WriteLine("\n--------\n");
        }

    }
}