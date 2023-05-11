using System;
using System.Collections.Generic;

class Film
{
    public string Ad { get; set; }
    public List<DateTime> SeansSaatleri { get; set; }

    public Film(string ad)
    {
        Ad = ad;
        SeansSaatleri = new List<DateTime>();
    }
}

class Salon
{
    public string Ad { get; set; }
    public int KoltukKapasitesi { get; set; }

    public Salon(string ad, int koltukKapasitesi)
    {
        Ad = ad;
        KoltukKapasitesi = koltukKapasitesi;
    }
}

class Seans
{
    public Film Film { get; set; }
    public Salon Salon { get; set; }
    public DateTime Tarih { get; set; }

    public Seans(Film film, Salon salon, DateTime tarih)
    {
        Film = film;
        Salon = salon;
        Tarih = tarih;
    }
}

class Rezervasyon
{
    public Seans Seans { get; set; }
    public string MusteriAdSoyad { get; set; }
    public int BiletAdedi { get; set; }
    public int KoltukNo { get; set; }

    public Rezervasyon(Seans seans, string musteriAdSoyad, int biletAdedi, int koltukNo)
    {
        Seans = seans;
        MusteriAdSoyad = musteriAdSoyad;
        BiletAdedi = biletAdedi;
        KoltukNo = koltukNo;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Film ve seansları oluşturma
        Film film1 = new Film("Avatar");
        film1.SeansSaatleri.Add(new DateTime(2023, 5, 11, 10, 0, 0));
        film1.SeansSaatleri.Add(new DateTime(2023, 5, 11, 14, 0, 0));

        Film film2 = new Film("Inception");
        film2.SeansSaatleri.Add(new DateTime(2023, 5, 11, 12, 0, 0));
        film2.SeansSaatleri.Add(new DateTime(2023, 5, 11, 16, 0, 0));

        // Salon oluşturma
        Salon salon1 = new Salon("Salon 1", 100);

        // Seansları oluşturma
        Seans seans1 = new Seans(film1, salon1, new DateTime(2023, 5, 11, 10, 0, 0));
        Seans seans2 = new Seans(film1, salon1, new DateTime(2023, 5, 11, 14, 0, 0));
        Seans seans3 = new Seans(film2, salon1, new DateTime(2023, 5, 11, 12, 0, 0));
        Seans seans4 = new Seans(film2, salon1, new DateTime(2023, 5, 11, 16, 0, 0));

        // seansları tek bir liste üzerinde toplamak.
                List<Seans> seanslar = new List<Seans> { seans1, seans2, seans3, seans4 };

        // kullanıcı için arayüz.
        Console.WriteLine("Film Seçiniz:");
        for (int i = 0; i < seanslar.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {seanslar[i].Film.Ad} - {seanslar[i].Tarih.ToString("dd.MM.yyyy HH:mm")}");
        }

        int secim;
        bool gecerliSecim = false;

        do
        {
            Console.Write("Seçiminizi yapınız (1-4): ");
            string secimStr = Console.ReadLine();

            if (int.TryParse(secimStr, out secim))
            {
                if (secim >= 1 && secim <= 4)
                {
                    gecerliSecim = true;
                }
            }

            if (!gecerliSecim)
            {
                Console.WriteLine("Geçersiz seçim.");
            }

        } while (!gecerliSecim);

        Seans secilenSeans = seanslar[secim - 1];

        Console.Write("Müşteri Ad Soyad: ");
        string adSoyad = Console.ReadLine();

        Console.Write("Bilet Adedi: ");
        int biletAdedi = Convert.ToInt32(Console.ReadLine());

        Console.Write("Koltuk No: ");
        int koltukNo = Convert.ToInt32(Console.ReadLine());

        // Rezervasyon oluşturma
        Rezervasyon rezervasyon = new Rezervasyon(secilenSeans, adSoyad, biletAdedi, koltukNo);

        // Rezervasyon bilgilerini gösterme
        Console.WriteLine("Rezervasyon Bilgileri:");
        Console.WriteLine("Film: " + rezervasyon.Seans.Film.Ad);
        Console.WriteLine("Salon: " + rezervasyon.Seans.Salon.Ad);
        Console.WriteLine("Tarih: " + rezervasyon.Seans.Tarih.ToString("dd.MM.yyyy HH:mm"));
        Console.WriteLine("Müşteri Ad Soyad: " + rezervasyon.MusteriAdSoyad);
        Console.WriteLine("Bilet Adedi: " + rezervasyon.BiletAdedi);
        Console.WriteLine("Koltuk No: " + rezervasyon.KoltukNo);

        Console.ReadLine();
    }
}

