<div align ="center">    
    
# :hibiscus: Cicek Sepeti Test Automation Bootcamp Project :hibiscus: 

</div>

:pushpin: **Senaryo 1.2: Otomasyon yazılması.**

- Test otomasyon çalışmaları hem zaman kaybını hem de hata oranını en aza indirmek için yapılır. Testlerin verimli ve hızlı gerçekleşmesi, yazılım geliştirme süreçlerinde önemli bir katkı sağlamaktadır.
- Sürekli gelişen sistemler, aynı test planının tekrar tekrar yürütülmesini gerektirecektir. Bir test otomasyon aracı kullanarak, bu test planını kaydetmek ve gerektiğinde yeniden oynatmak mümkündür.
- Bu caseler; Python dilinde yazılmıştır. Python nesne yönelimli, yorumsal, modüler ve etkileşimli, yüksek seviyeli bir dildir.
Seçtiğim caseler doğrultusunda, yapılmak istenen işleri hızlı bir şekilde daha az kod satırıyla yapılabileceğini düşündüğüm için bu yolu tercih ettim.
- Her türlü yazılım testi için kullanılan ve test otomasyonu için bir Python frameworkü olan pytest kullanıldı. Ayrıca Selenium gibi teknolojilere yer verildi.
- Page object model kullanılmış olup, IDE olarak PyCharm ile çalışılmıştır. Page Object Model, yani kısaca POM, kod tekrarını azaltmada faydalıdır ve test senaryosu bakımını iyileştirir. Bir uygulamanın her web sayfasını bir sınıf dosyası olarak düşünebiliriz.
- Testlerin çalışması için, **Pycharm üzerinden, Shift+F10**'a basılması yeterlidir.
&nbsp;

<div align ="center">
  
# Python Tests- Case 3 & Case 5 
</div align ="center">

:fish_cake: **test_mizu:** Testlerin dahil olduğu klasördür. Driver burada tanımlanmıştır. Setup ve teardown dahilinde browser açılımı ve kapanışı yer almaktadır. Testlerden önce ve sonra çalışır. 
&nbsp;

:fish_cake: **homePage:** "https://www.mizu.com/" sayfasına gidilir. Pencere büyütülerek pop-up'lar kapatılır. Testlerin başında çalışır.
&nbsp;

<div align ="center">
  
# :dart: Case 3 :dart:
</div align ="center">

:white_check_mark: **https://www.mizu.com/flowers ‘da aşağı scroll yaptıkça ilk 10 sayfa için her sayfada 60 ürün geldiğinin kontrolü.**
&nbsp;

- İlk önce Home Page açılıp sonra flowers kategorisine gidilmiştir.
- Flowers kategorisinin ilk 10 sayfası için bir for loop geliştirilmiştir.
- Sayfa numaraları (pageNum) 1 artarak ilerleyip, kontrolü URL üzerinden yapılmıştır.
- Ürünler ise (product) 60 artarak ilerlemiştir. Çünkü 1 sayfada 60 adet ürün bulunmaktadır.
- İlk sayfamızın URL'inde 1 yazmadığı için bir if case kullanılmıştır.
- Eğer URL'imiz sadece flowers sayfasını gösteriyorsa 1. sayfadayızdır. 60. ürün görünene kadar scroll yapılmıştır ve 60. ürünün varlığı click ile kontrol edilmiştir. Eğer ürün tıklanılabilirse var demektir. İlk sayfada 60 ürün olduğu kanıtlanır ve true assertini alırız. 
- Eğer URL'imizde sayfa numarası bulunuyorsa, burada else if kısmına geçiyoruz.
- 2'den 10'a kadar sayfa numaraları loop'a alınmıştır. 60 60 artarak ilerleyen ürünlerden, sayfa numarası ile senkronize bir şekilde, 60'ın katları olarak son ürünler kontrol edilmiştir. Bu son ürün tıklanabilme özelliğine sahip ise true döner ve varlığı kanıtlanarak her sayfada 60 ürün olduğu anlaşılmıştır.
&nbsp;

*:exclamation: **Not:** Detaylar kod içerisinde, yorum satırlarında açıklanmıştır.*
&nbsp;

*:exclamation: **Not:** Not: driver path'i kişisel bilgisayarıma göredir.*
&nbsp;

<div align ="center">
  
# :dart: Case 5 :dart:
</div align ="center">

:white_check_mark: **https://www.mizu.com/flowers sayfasında filtre alanından sort: price high to low seçilip listeleme sayfasındaki ürünlerin doğru fiyat sırasıyla listelendiğinin kontrolü.**
&nbsp;

- İlk önce Home Page açılıp sonra flowers kategorisine gidilmiştir. Yada iki test de aynı anda çalıştırılmışsa, sadece flowers kategorisine gidilmiştir.
- Flowers sayfasında bulunan sort filtresi üzerinden high to low filtresi seçilmiştir.
- İlk önce boş bir array (arr) atanmıştır.
- Ürünlerin fiyat kontrolü için for loop geliştirilmiştir.
- Ürünler (element) 1er artarak ilerlemiştir.
- Ürünün fiyat kontrolü için; noktadan öncesi (integer), noktadan sonrası için (decimal) olarak tanımlanıp ayrılmıştır.
- Integer kısmında virgül olduğundan ve hatalı sıralamaya yönlendireceğinden ötürü, virgülün iki tarafı da ayrılmıştır. Ardından virgül çıkarılarak tekrardan birleştirilmiştir.
- Integer ve decimal kısımları toplanmıştır ve totalPrice olarak tanımlanmıştır.
- Daha önce tanımlanan boş arraye totalPricelar atanmıştır (arr).
- Daha sonra arr içindeki totalPrice'lar büyükten küçüğe sıralanmıştır ve bu sıralanan totalPrice'lar highToLowList diye tanımlanmıştır.
- Ardından arr (sitenin sıraladığı liste) ile highToLowList (benim büyükten küçüğe sıraladığım liste)'nin eşit olup olmadığı kontrol edilmiştir.
&nbsp;

*:exclamation: **Not:** Detaylar kod içerisinde, yorum satırlarında açıklanmıştır.*
&nbsp;

<div align ="center">
  
  # :four_leaf_clover: Sonuçlar :four_leaf_clover:
  &nbsp;
  
<a href="https://resimlink.com/wK6XO" title="ResimLink - Resim Yükle"><img src="https://r.resimlink.com/wK6XO.jpg" title="ResimLink - Resim Yükle" alt="ResimLink - Resim Yükle"></a>
</div align ="center">
&nbsp;

 :star: [Ayrıca medium üzerinden yazdığım ve adım adım ilerlediğim, "Page Object Model ile Python Test Otomasyonu" yazısına bakmanızı öneririm](https://medium.com/@iremuludirik/page-object-model-ile-python-test-otomasyonu-38d7f10a5658) :star:
