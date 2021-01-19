using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Liste(Musteri musteri)
        {
            Console.WriteLine( musteri.Id + " " + " id numaralı" + " " + musteri.Adi + " " + musteri.soyadi);
        }


        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + " id numaralı" + " " + musteri.Adi + " " + musteri.soyadi+ " " + "listeye eklendi");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + " id numaralı" + " " + musteri.Adi + " " + musteri.soyadi + " " + "listeden silindi");
        }
        public void islem(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + " id numaralı" + " " + musteri.Adi + " " + musteri.soyadi );
        }
        


    }
}
