using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Fatma";
            musteri1.MusteriSoyadı = "Arı";
            musteri1.MusteriNo = "123456";
            musteri1.MusteriIslem = "İhtiyaç Kredisi";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Furkan";
            musteri2.MusteriSoyadı = "Bacacı";
            musteri2.MusteriNo = "147258";
            musteri2.MusteriIslem = "Konut Kredisi";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);







        }
    }
}
