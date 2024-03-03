using System;
namespace SinifKavramlari{
    class Program{
        public static void Main(string[] args){

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Yalcin";
            calisan1.SoyAd = "Mrl";
            calisan1.No = 23124;
            calisan1.Departman = "Gelistirici";

            calisan1.CalisanBilgiler();

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Ayse";
            calisan2.SoyAd = "deniz";
            calisan2.No = 231286;
            calisan2.Departman = "insan kaynaklari";

            calisan2.CalisanBilgiler();

        }
    }

    class Calisan{
        public string Ad;
        public string SoyAd;

        public int No;
        public string Departman;

        public void CalisanBilgiler(){
            Console.WriteLine("Calisan adi : " + Ad);
            Console.WriteLine("Calisan Soyadi : {0}",SoyAd);
            Console.WriteLine("Calisan Numarasi : " + No);
            Console.WriteLine("Calisan Departman : "+ Departman);
        }
    }
}