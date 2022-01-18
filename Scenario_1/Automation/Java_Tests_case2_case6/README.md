<div align ="center">   
    
# :hibiscus: Cicek Sepeti Test Automation Bootcamp Project :hibiscus: 

</div>

:pushpin: **Senaryo 1.2: Otomasyon yazılması.**
&nbsp;

- Test otomasyon çalışmaları hem zaman kaybını hem de hata oranını en aza indirmek için  yapılır. Testlerin verimli 
ve hızlı gerçekleşmesi, yazılım geliştirme süreçlerinde önemli bir katkı sağlamaktadır. 
- Sürekli gelişen sistemler, aynı test planının tekrar tekrar yürütülmesini gerektirecektir. Bir test otomasyon aracı kullanarak, bu test planını kaydetmek ve gerektiğinde yeniden oynatmak mümkündür.
- Java, kendi platformunda bağımsız olarak çalışması, yüksek performansı, güvenilir, aynı anda birden fazla işi yapabilmesi ve esnek bir dil olması nedeniyle, bu caseler için uygun gördüğm bir dildir.
-  Maven öncelikle Java projeleri için kullanılan bir yapı otomasyon aracıdır. Maven ile birlikte testNG, Selenium, Bonigarcia, junit, jsoup gibi kullanılacak paketler yüklendi. 
- Page object model kullanılmış olup, IDE olarak Intelli J Idea ile çalışılmıştır. Page Object Model, yani kısaca POM, kod tekrarını azaltmada faydalıdır ve test senaryosu bakımını iyileştirir. Bir uygulamanın her web sayfasını bir sınıf dosyası olarak düşünebiliriz.
- Testlerin çalışması için, **Intelli J Idea üzerinden, Shift+F10**'a basılması yeterlidir.
<div align ="center">
  
# Java Tests- Case 2 & Case 6 
</div align ="center"> 
&nbsp;

:fish_cake: **MizuTest:** Testlerin dahil olduğu klasördür.. 
&nbsp;

:fish_cake: **BasePage:** Driver ve wait fonksiyonu burada tanımlanmıştır. 
&nbsp;

:fish_cake: **BaseTest:** Browser burada tanımlanmıştır. setup ve teardown dahilinde browser açılımı ve kapanışı yer almaktadır. Testlerden önce ve sonra çalışır. 
&nbsp;

:fish_cake: **homePage:** "https://www.mizu.com/" sayfasına gidilir. Pencere büyütülerek pop-up'lar kapatılır. Testlerin başında çalışır. 
&nbsp;

<div align ="center">
  
# :dart: Case 2 :dart:
</div align ="center">

:white_check_mark: **https://www.mizu.com/en-mx/portarretratos-de-cristal-personalizado-cancion-kcm64138299 ürünün kişiselleştirilip sepete eklenmesi.**
&nbsp;

- İlk önce Home Page açılmıştır. 
- Aranacak ürün ismi arama kutucuğuna yazılmıştır.
- Çıkan ürünlerden istenilen ürün seçilmiştir.
- Sepete ekle butonuna basılmıştır.
- Kişiselleştirme için text girilmiştir.
- Bu kısımdan sonra, RobotTest Page'ine geçilerek robot komutları uygulanmıştır.
- Yüklenecek görselin path'i tanımlanmıştır.
- Robot komutları ile birlikte görsel yüklenmiştir.
- Ardından confirmation kutucuğu checklenmiştir.
- Next butonuna basılarak sepetim'e gidilmiştir.
- Sepetime eklendiği kontrol edilmiştir.
&nbsp; 

*:exclamation: **Not:** Detaylar kod içerisinde, yorum satırlarında açıklanmıştır.*
&nbsp;

*:exclamation: **Not:** Not: driver path'i kişisel bilgisayarıma göredir.*
&nbsp;

<div align ="center">
  
# :dart: Case 6 :dart:
</div align ="center">

:white_check_mark: **https://www.mizu.com menu altında bulunan tüm alt kategorilerin linklerinin kırık olup olmadığının kontrolü.**
&nbsp;

- İlk önce Home Page açılmıştır.
- Base URL belirlenerek, içerisindeki bütün linkler çekilmiştir.
- Linkler içerisindeki başlıklar alınmıştır.
- Gelen bazı linklerde base URL tespit edilmediği için, if case kullanılarak base URL'i olmayan linklere base URL eklendi.
- Gelen bazı linkler kategori olmadığı için, kategori dışında kalan linkler notCat içerisinde tanımlanmıştır.
- linkList adında boş bir array açılmıştır.
- Gelen bazı linklerin başlığı boş olduğu ve bazı linklerin sonunda "(0)" olduğu tespit edilmiştir. Ardından notCat içerisinde bulunan kategori olmayan linkler ile birlikte, filter fonksiyonu içerisinde if case ile çıkarılmıştır.
- Temizlenen linklerin başlıkları, linklerin sonundaki başlığı temsil eden yazı ile aynı olsun ve karşılaştırma yapılabilsin diye, başlıklar küçük harfe çevrilip, kelimeler arasındaki boşluklar da "-" ye çevrilmiştir.
- Ardından linkList array'ine başlık:link şeklinde eklenmiştir.    
- notDoublelink adında boş bir array açılmıştır.
- linkList içerisindeki linklerden bazıları birden fazla olduğu için, birden fazla tekrar eden linkleri sadece bir kere saydırıp notDoublelink listesine eklenmiştir.
- Böylelikle istediğimiz kontroller adım adım yapılmıştır.
&nbsp;

*:exclamation: **Not:** Detaylar kod içerisinde, yorum satırlarında açıklanmıştır.*
&nbsp;

<div align ="center">
  
  # :four_leaf_clover: Sonuçlar :four_leaf_clover:
  &nbsp;
  
<a href="https://resimlink.com/ZHJTLvK" title="ResimLink - Resim Yükle"><img src="https://r.resimlink.com/ZHJTLvK.jpg" title="ResimLink - Resim Yükle" alt="ResimLink - Resim Yükle"></a>
</div align ="center">

