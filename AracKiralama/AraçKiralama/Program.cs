using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraçKiralama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Acente acente= new Acente();
            acente.aracEkle(new Arac {aracId = 1, marka = "Mercedes", model="Cla-200", modelYili = 2023, plaka = "34BC406", aracFiyat = 1000, firmaName="Gelecek Otomotiv", firmaAdres="İstanbul/Kadıköy", firmaTel= "0412659875"});
 
            acente.kullanıcıEkle(new Musteri { musteriID = 1, adres = "İstanbul/Beşiktaş ", musteriName = "Ali", musteriSurname = "Ertuğrul", musteriTelNo = "0412563245" });
            acente.aracSec(1);
            
            acente.sozlesmeFormu(1, 1);
            

           

        }
    }
}
