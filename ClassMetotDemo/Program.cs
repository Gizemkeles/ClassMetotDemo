using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
                     
                                 
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Mustafa";
            musteri1.soyadi = "Yıldız";
            musteri1.yasi = 34;

            

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Emine";
            musteri2.soyadi = "Sarı";
            musteri2.yasi = 53;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Hasan";
            musteri3.soyadi = "Kaya";
            musteri3.yasi = 48;

            


            Musteri[] musteriler = new Musteri[] { musteri1,musteri2,musteri3};
            
            {
                Console.WriteLine("----Bankamıza Hoşgeldiniz----");
                
                
                


            }
           



            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("Müşteriler Listeleniyor!");
            musteriManager.Liste(musteri1);
            musteriManager.Liste(musteri2);
            musteriManager.Liste(musteri3);

            

            Console.WriteLine("--------------------");
            Musteri musteri4 = new Musteri();
            Console.WriteLine("Müşteriler Ekleniyor!");
            musteri4.Id = 4;
            musteri4.Adi = "Betül";
            musteri4.soyadi = "Kılıç";
            musteri4.yasi = 28;

            Musteri musteri5 = new Musteri();
            musteri5.Id = 5;
            musteri5.Adi = "Ali";
            musteri5.soyadi = "Vural";
            musteri5.yasi = 65;


            musteriManager.Ekle(musteri4);
            musteriManager.Ekle(musteri5);
           

            Console.WriteLine("--------------------");
            Console.WriteLine("Müşteriler Siliniyor!");
            musteriManager.Sil(musteri1);


            Console.WriteLine("--------------------");
            Console.WriteLine("İşlemi Gerçekleştirilen Müşteriler ");
            musteriManager.islem(musteri2);
            musteriManager.islem(musteri3);
            musteriManager.islem(musteri4);
            musteriManager.islem(musteri5);

            Console.WriteLine("Değerli müşterimiz,bizi tercih ettiğiniz için teşekkür ederiz. ");







        }
    }
}
