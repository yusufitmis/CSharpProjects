using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KütüphaneTakipSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kutuphane kütüphane = new Kutuphane();

            // Raf ekleme
            kütüphane.raflar.Add(new Raf { rafID = 1, rafKod = "A1" });
            kütüphane.raflar.Add(new Raf { rafID = 2, rafKod = "B1" });

            // Kitap ekleme
            kütüphane.KitapEkle(new Kitap { id = 1, name = "Kitap 1", rafID = 1, raftaMı = false });
            kütüphane.KitapEkle(new Kitap { id = 2, name = "Kitap 2", rafID = 2, raftaMı = true });

            // Kullanıcı ekleme
            kütüphane.KullanıcıEkle(new Kullanici { kullaniciID = 1, name = "Kullanıcı 1", oduncKitaplar = new List<int> { 2 } });

            // Kitabı dışarı al
            kütüphane.KitapDışarıAl(1);

            // Kitabı geri ver
            kütüphane.KitapGeriVer(2);

            // Kullanıcının ödünç aldığı kitapları listele
            Kullanici kullanıcı = kütüphane.kullanicilar.Find(k => k.kullaniciID == 1);
            Console.WriteLine("Kullanıcının ödünç aldığı kitaplar:");
            foreach (int kitapID in kullanıcı.oduncKitaplar)
            {
                Kitap ödünçKitap = kütüphane.kitaplar.Find(k => k.id == kitapID);
                Console.WriteLine(ödünçKitap.name);
            }
        }
    }
}
