using System;
using System.Collections.Generic;


namespace AraçKiralama
{
    internal class Arac:AracManager
    {
        public string marka;
        public string model;
        public int modelYili;
        public int aracId;
        public string plaka;
        public string firmaName;
        public string firmaAdres;
        public string firmaTel;
        public int aracFiyat;
        
    }
    internal class AracManager
    {
        public string aracAlısTar;
        public string aracTeslimTar;
        

    }
    internal class Musteri{
        public string musteriName;
        public string musteriSurname;
        public string musteriTelNo;
        public int musteriID;
        public string adres;
        
    }
    internal class Acente
    {
        public List<Arac> Filo;
        public List<Musteri> Musteriler;
        public Acente()
        {
            Filo = new List<Arac>();
            Musteriler= new List<Musteri>();
        }
        public void aracEkle(Arac arac)
        {
            Filo.Add(arac);
        }
        public void kullanıcıEkle(Musteri musteri)
        {
            Musteriler.Add(musteri);   
        }
        // araç filoda mı değil mi kontrol etme
        public void aracSec(int aracID)
        {
            Console.WriteLine("Araç filoda var mı ?");
            Arac arac = Filo.Find(k => k.aracId == aracID);
            if (arac != null)
            {
                Console.WriteLine("var");
            }
        }

        public void sozlesmeFormu(int musteriID, int aracID)
        {
            Arac arac = Filo.Find(k => k.aracId == aracID);
            Musteri musteri = Musteriler.Find(k => k.musteriID == musteriID);
            if((arac != null) && (musteri != null))
            {
                Console.WriteLine("Araç Alış Tarihini Girin: yyyy/aa//gg ");
                var aracAlısTar = Console.ReadLine();
                // Araç teslim tarihi
                Console.WriteLine("Araç Teslim Tarihini Girin: yyyy/aa//gg ");
                var aracTeslimTar = Console.ReadLine();
                Console.WriteLine("--------ARAÇ KİRALAMA SÖZLEŞMESİ------");
                Console.WriteLine($"\nKiracı Bilgisi\n----------------------------------");
                Console.WriteLine($" AD: {musteri.musteriName}\n SOYAD: {musteri.musteriSurname}\n ADRES: {musteri.adres}\n TEL: {musteri.musteriTelNo}");
                Console.WriteLine("\nKiralayan Bilgisi\n----------------------------------  ");
                Console.WriteLine($" Firma Adı: {arac.firmaName}\n Firma Adresi: {arac.firmaAdres}\n Firma Telefon: {arac.firmaTel}");
                Console.WriteLine("\nKiralanan Araç Bilgisi\n-------------------------------");
                Console.Write($" Plaka No: {arac.plaka}    Marka: {arac.marka}   Model: {arac.model}\n");
                Console.WriteLine("\nKiralama Bilgileri\n----------------------------");
                aracTeslim(1, aracAlısTar, aracTeslimTar);


            }
        }
        public void aracTeslim(int aracID,string aracAlısTar, string aracTeslimTar)
        {
           Arac arac = Filo.Find(k => k.aracId == aracID);
            if (arac != null)
            {
                //araç alış tarihi
                
                DateTime alisTarihi = DateTime.Parse(aracAlısTar);
                DateTime verisTarih = DateTime.Parse(aracTeslimTar);
                // araç kaç gün kiralancak
                var rezerveTarih = verisTarih- alisTarihi;
                // araç alış-teslim yerleri
                var aracTeslimYeri = "HunTur Ümraniye Şubesi";
                var aracAlisYeri = "HunTur Kartal Şubesi";
                var kiralamaFiyat = arac.aracFiyat * rezerveTarih.Days;
                Console.WriteLine($" Araç Alış Tarihi: {aracAlısTar}\n Araç Teslim Tarihi: {aracTeslimTar}\n" +
                    $" Araç Alış Yeri: {aracAlisYeri}\n Araç Teslim Yeri: {aracTeslimYeri}\n Kiralama Bedeli = {rezerveTarih.Days} Gün {kiralamaFiyat} Tl");
                
            }
        }


    }
    
    
   
}
