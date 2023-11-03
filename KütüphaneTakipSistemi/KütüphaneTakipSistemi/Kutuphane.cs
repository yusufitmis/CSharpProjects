using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KütüphaneTakipSistemi
{
    internal class Kutuphane
    {
        public List<Kitap> kitaplar;
        public List<Kullanici> kullanicilar;
        public List<Raf> raflar;
        public Kutuphane() {
            kitaplar= new List<Kitap>();
            kullanicilar= new List<Kullanici>();
            raflar= new List<Raf>();
        }
        public void KitapEkle(Kitap kitap)
        {
            kitaplar.Add(kitap);
        }
        public void KullanıcıEkle(Kullanici kullanici)
        {
            kullanicilar.Add(kullanici);
        }
        public void KitapDışarıAl(int kitapID)
        {
            Kitap kitap = kitaplar.Find(k => k.id == kitapID);
            if (kitap != null)
            {
                kitap.raftaMı = true;
            }
        }

        public void KitapGeriVer(int kitapID)
        {
            Kitap kitap = kitaplar.Find(k => k.id == kitapID);
            if (kitap != null)
            {
                kitap.raftaMı = false;
            }
        }
    }
}
