# C# İle Araç Kiralama Konsol Uygulaması
![image](https://github.com/yusufitmis/CSharpProjects/blob/main/AracKiralama/readme.png)
#### Uygulamanın Amacı : Sahip olunan araçlar sisteme kayıt edilir ve kiralama işlemi sırasıda kiralayan bilgileri alınarak bir sözleşme formu otomatik olarak oluşturulur.
#### Uygulamanın Yapılışı
      1. Arac isminde bir sınıf oluşturuyoruz. Bu sınıf Aracın isim,marka,model,modelyılı, fiyat, firma bilgilerini içerir.
      2. Müşteri isminde bir sınıf oluşturuyoruz. Bu sınıf Müşterinin bilgilerini içerir.
      3. Acente isminde bir sınıf oluşturuyoruz. 
         a.Bu sınıf Aractan türeyen objeleri listeleyen Filo, Müsteriden türeyen objeleri listeleyen Müsteriler propertiylerini içerir.
         b. Public Acente() isinde bir consturctera sahiptir. Bu constructer çalıştığında yeni bir filo, müsteriler listesi oluşur.
         c.aracEkle() fonksiyonuyla arac objelerini filoya ekleriz.
         d.kullanıcıEkle() fonksiyonuyla musteri objelerini Musterier listesine ekleriz.
         e.aracSec() fonksiyonuyla araç filoda mı değil mi diye kontrol ederiz.
         f.aracTeslim() ile aracın alınış ve teslim tarihlerini, alınış ve teslim yerlerini ve kaç gün kiralandıysa ücretini hesaplıyoruz (Datetime kullanılır)
         g.sozlesmeFormu() ile de sözleşme formu oluştururuz.
      4.main içde acente objesi oluşturuyoruz. acente.aracEkle() ile arac, acente.kullanıcıEkle() ile müsteri ekleriz
NOT: Arac, Musteriler, Acente sınıfı Arac.cs, main ise program.cs dosyası içinde bulunmaktadır.<br>
Bu proje Visual Studio 2022 kullanılarak yapılmıştır.


         

