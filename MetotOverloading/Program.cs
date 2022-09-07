using System;

namespace MetotOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi="999";
            int outSayi;
            bool sonuc=int.TryParse(sayi, out outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }

            Metotlar instance=new Metotlar();
            instance.Topla(4,5,out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            //Metot Overloading
            int ifade=999;
            instance.EkranaYazdir(ifade.ToString());
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Ayça","Doğan");

            //Metot imzası:
            //Metot adı+Parametre Sayısı+Parametre
        }
    }

    class Metotlar
    {
        public void Topla(int a, int b,out int toplam)
        {
         toplam=a+b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1+veri2);
        }
    }
}
