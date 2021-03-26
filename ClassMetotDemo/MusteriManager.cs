using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listesine Eklendi:" + musteri.MusteriAdi + " " + musteri.MusteriSoyadı);
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listesinden Silindi:" + musteri.MusteriAdi + " " + musteri.MusteriSoyadı);
        } 
        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("toplam Müşteri Listesi Gösterildi:"+musteri.MusteriAdi+" "+musteri.MusteriSoyadı);
        }
    }
}
