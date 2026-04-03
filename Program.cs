////UYGULAMA 1: Araba Örneği
//using System;

//// Araba sınıfı: Bir arabanın özelliklerini ve davranışlarını tanımlar
//class Araba
//{
//    // Özellikler / Değişkenler (Fields)
//    // Arabanın temel bilgileri
//    public string Marka;
//    public string Model;
//    public string Renk;
//    public int Hiz;

//    // Arabanın çalıştırılmasını sağlayan metot
//    public void Calistir()
//    {
//        Console.WriteLine("Araba çalıştırıldı.");
//    }

//    // Arabanın hızlanmasını sağlayan metot
//    // artis parametresi hıza eklenecek değeri belirtir
//    public void Git(int artis)
//    {
//        Hiz += artis;
//        Console.WriteLine("Araba gidiyor. Hız: " + Hiz + " km/s");
//    }

//    // Arabanın durmasını sağlayan metot
//    public void Dur()
//    {
//        Hiz = 0;
//        Console.WriteLine("Araba durdu.");
//    }

//    // Arabanın bilgilerini ekrana yazdıran metot
//    public void BilgiYazdir()
//    {
//        Console.WriteLine("Araba Bilgileri");
//        Console.WriteLine("Marka: " + Marka);
//        Console.WriteLine("Model: " + Model);
//        Console.WriteLine("Renk : " + Renk);
//        Console.WriteLine("Hız   : " + Hiz + " km/s");
//        Console.WriteLine("----------------------");
//    }
//}


//// Program sınıfı: Uygulamanın çalıştığı ana bölüm
//class Program
//{
//    static void Main(string[] args)
//    {
//        // 1. Araba nesnesi oluşturuluyor
//        Araba araba1 = new Araba();

//        // 1. arabanın özelliklerine değer atanıyor
//        araba1.Marka = "BMW";
//        araba1.Model = "320i";
//        araba1.Renk = "Siyah";
//        araba1.Hiz = 0;

//        // Araba bilgileri ekrana yazdırılıyor
//        araba1.BilgiYazdir();

//        // 1. arabanın davranışları
//        araba1.Calistir();
//        araba1.Git(50);
//        araba1.Git(30);
//        araba1.Git(40);
//        araba1.Dur();


//        // 2. Araba nesnesi oluşturuluyor
//        Araba araba2 = new Araba();

//        // 2. arabanın özelliklerine değer atanıyor
//        araba2.Marka = "TOGG";
//        araba2.Model = "T10X";
//        araba2.Renk = "Seyhan";
//        araba2.Hiz = 0;

//        // 2. araba bilgileri yazdırılıyor
//        araba2.BilgiYazdir();

//        // 2. arabanın davranışları
//        araba2.Calistir();
//        araba2.Git(50);
//    }
//}





//UYGULAMA 2: Öğrenci Bilgi Sistemi
using System;

// Öğrenci sınıfı: Bir öğrencinin bilgilerini ve davranışlarını tutar
class Ogrenci
{
    // Özellikler / Değişkenler (Fields)
    // Öğrencinin temel bilgileri
    public long OgrenciNo;
    public string Ad;
    public string Soyad;
    public string Bolum;

    // Öğrencinin dönem sonu ortalaması
    public double Ortalama;

    // Öğrenci bilgilerini ekrana yazdıran metot
    public void BilgiYazdir()
    {
        Console.WriteLine("Öğrenci Bilgileri");
        Console.WriteLine("Numara : " + OgrenciNo);
        Console.WriteLine("Ad     : " + Ad + " " + Soyad);
        Console.WriteLine("Bölüm  : " + Bolum);
        Console.WriteLine("Ortalama : " + Ortalama);
        Console.WriteLine("----------------------");
    }

    // Vize %40 - Final %60 olacak şekilde ortalama hesaplar
    public void OrtalamaHesapla_VizeFinal(int vize, int final)
    {
        Ortalama = vize * 0.40 + final * 0.60;
    }

    // Vize %30 - Final %40 - Proje %30 olacak şekilde ortalama hesaplar
    public void OrtalamaHesapla_VizeFinalProje(int vize, int final, int proje)
    {
        Ortalama = vize * 0.30 + final * 0.40 + proje * 0.30;
    }

    // Vize %20 - Final %30 - Proje %25 - Ödev %25 olacak şekilde ortalama hesaplar
    public void OrtalamaHesapla_Dortlu(int vize, int final, int proje, int odev)
    {
        Ortalama = vize * 0.20 + final * 0.30 + proje * 0.25 + odev * 0.25;
    }

    // Öğrencinin geçip geçmediğini kontrol eder
    public void DurumYazdir()
    {
        if (Ortalama >= 70)
            Console.WriteLine("Durum : Geçti");
        else
            Console.WriteLine("Durum : Kaldı");
    }
}


// Program sınıfı: Uygulamanın çalıştığı ana kısım
class Program
{
    static void Main(string[] args)
    {
        // MAKÜ Teknik Bilimler Meslek Yüksekokulu öğrencisi
        Ogrenci ogrenci1 = new Ogrenci();
        // Öğrenci 1 bilgileri
        ogrenci1.OgrenciNo = 2513409010;
        ogrenci1.Ad = "Hasan Mert";
        ogrenci1.Soyad = "BÜLBÜL";
        ogrenci1.Bolum = "Bilgisayar Programcılığı";
        // Not hesaplama
        ogrenci1.OrtalamaHesapla_VizeFinal(80, 90);
        // Bilgileri ve durumu yazdırma
        ogrenci1.BilgiYazdir();
        ogrenci1.DurumYazdir();


        // MAKÜ Mühendislik Fakültesi öğrencisi
        Ogrenci ogrenci2 = new Ogrenci();
        // Öğrenci 2 bilgileri
        ogrenci2.OgrenciNo = 2540409105;
        ogrenci2.Ad = "Ayşe";
        ogrenci2.Soyad = "KAHRAMAN";
        ogrenci2.Bolum = "Bilgisayar Mühendisliği";
        // Not hesaplama (vize + final + proje)
        ogrenci2.OrtalamaHesapla_VizeFinalProje(80, 70, 90);
        // Bilgileri ve durumu yazdırma
        ogrenci2.BilgiYazdir();
        ogrenci2.DurumYazdir();
    }
}

