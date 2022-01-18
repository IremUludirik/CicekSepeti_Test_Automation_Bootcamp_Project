<div align ="center">   
    
# :hibiscus: Cicek Sepeti Test Automation Bootcamp Project :hibiscus: 

</div>

:pushpin: **Senaryo 1.2: Otomasyon yazılması.**
&nbsp;

- Test otomasyon çalışmaları hem zaman kaybını hem de hata oranını en aza indirmek için  yapılır. Testlerin verimli 
ve hızlı gerçekleşmesi, yazılım geliştirme süreçlerinde önemli bir katkı sağlamaktadır. 
- Sürekli gelişen sistemler, aynı test planının tekrar tekrar yürütülmesini gerektirecektir. Bir test otomasyon aracı kullanarak, bu test planını kaydetmek ve gerektiğinde yeniden oynatmak mümkündür.
- Bu caseler; .netCore kullanılarak C# dilinde yazılmıştır. .NET Core, Microsoft ve .NET topluluğu tarafından geliştirilmiş ve geliştirilmeye devam eden, Github üzerinde bulunan açık kaynaklı, çapraz platform geliştirme yapmaya olanak sağlayan bir platformdur. 
- NUnit, specflow, selenium webdriver gibi teknolojilere yer verilmiştir. Ayrıca VS Code extensionları olarak NuGetPackage Manager, .Net Core Test Explorer, cucumber, Specflow Tools gibi bir çok paket kullanılmıştır.
- Page object model kullanılmış olup, IDE olarak Visual Studio Code ile çalışılmıştır. Page Object Model, yani kısaca POM, kod tekrarını azaltmada faydalıdır ve test senaryosu bakımını iyileştirir. Bir uygulamanın her web sayfasını bir sınıf dosyası olarak düşünebiliriz.
- Bu teknolojilerin seçilmesinde senaryodan beklediğimiz cevap ve getirisi önemlidir. Senaryo dışına çıkmadan, farklı datalar ile, testler koşulmaya elverişli olduğu için davranış odaklı bir geliştirme yapmak istedim.
- Testlerin çalışması için, **VSCode'un kendi terminalinden "dotnet test"** yazılması gerekmektedir. 
&nbsp;

<div align ="center">
  
# .netCore Spectflow Tests- Case 1 & Case 4 
</div align ="center">


:fish_cake:**Feature:** Bir çeşit konu başlığı, devamında anlatılacak özelliği tanımlar.
&nbsp;

:fish_cake:**Background:** Senaryodan önceki durumu tanımlar.
&nbsp;

:fish_cake:**Scenario:** Konuyu anlatımının tanımlandığı yerdir. İçerik girilmez.
&nbsp;

:fish_cake: **Given:** Şu anki durumu tanımlar.
&nbsp;

:fish_cake:**When:** Aksiyonu tanımlar.
&nbsp;

:fish_cake:**Then:** İşlem sonundaki beklentileri tanımlar.
&nbsp;

:fish_cake: **BeforeandAfter:** Driver burada tanımlanmıştır. BeforeScenario ve AfterScenario dahilinde browser açılımı ve kapanışı yer almaktadır. Senaryolardan önce ve sonra çalışır.
&nbsp;

:fish_cake: **HomePage:** "https://www.mizu.com/" sayfasına gidilir. Pencere büyütülerek pop-up'lar kapatılır. Senaryo başında çalışır.
&nbsp;

<div align ="center">
  
# :dart: Case 1 :dart:
</div align ="center">

:white_check_mark: **https://www.mizu.com/login sayfasında kullanıcı adı ve şifre başarılı şekilde sign in olunması.**
&nbsp;

- Home Page açılır.
- Login Page'e gidilir.
- E-mail ve password girilir.
- Başarılı bir şekilde giriş gerçekleşir. 
- My Account yazısı kontrol edilir.
- Çıkış yapılır.
&nbsp;

:fish_cake: **LoginPage:** Senaryoya uygun stepler yer alır.
&nbsp;

:fish_cake: **LoginSteps:** LoginPage sayfasından stepleri çeker.
&nbsp;

*:exclamation: **Not:** Detaylar kod içerisinde, yorum satırlarında açıklanmıştır.*
&nbsp;

*:exclamation: **Not:** Login.feature dosyasında belirtilen, 3 farklı email ve password ile test edilmiştir.*
&nbsp;

<div align ="center">
  
# :dart: Case 4 :dart:
</div align ="center">

:white_check_mark: **https://www.mizu.com/flowers sayfasında gönderim yeri ‘mexico city’ seçilerek ilk ürün sepete eklenir ve ilgili adımlar(sepetim, teslimat adresi,fatura bilgileri) tamamlanarak ‘Oxxo’ ile ödeme alınması kontrol edilir.**
&nbsp;

- Home Page açılır.
- Flowers Page'e gidilir.
- Gönderim adresi "mexico city" seçilir.
- İlk çıkan ürüne basılarak ürün sayfasına gidilir.
- Gönderim için takvim üzerinden gün ayarlanır, ardından saat belirlenir.
- Sepete eklenir.
- Misafir girişi seçilerek sipariş sayfasına geçiş yapılır.
- Gönderilecek kişinin ismi, telefon numarası, adresi, adres numarası, posta kodu ve gönderim ismi belirlenir.
- Çıkan sayfalarda next butonlarına basılarak gönderenin bilgilerini almak üzere gönderen sayfasına geçiş yapılır.
- Gönderenin ismi, telefon numarası, e-maili ve ülke kodu belirlenir.
- Next butonuna basılarak ödeme sayfasına geçiş yapılır.
- Ödeme alınması için OXXO seçilir ve şartlar kutucuğu checklenir.
- Öde butonuna basılır.
- Onay mesajı kontrol edilir.
&nbsp;

:fish_cake: **FlowersPage:** Flower kategorisine ait stepler yer alır.
&nbsp;

:fish_cake: **ProductPage:** Ürün sayfasında gerçekleştirilen stepler yer alır.
&nbsp;

:fish_cake: **OrderPage:** Gönderilecek kişiye ait bilgiler için sipariş sayfasında gerçekleştirilen stepler yer alır.
&nbsp;

:fish_cake: **SenderPage:** Gönderen bilgileri için gerçekleştirilen stepler yer alır.
&nbsp;

:fish_cake: **PaymentPage:** Ödeme sayfasında gerçekleştirilen stepler yer alır.
&nbsp;

:fish_cake: **OxxoSteps:** Bütün senaryonun stepleri, ilgili sayfalardan çekilerek bir bütün oluşturulmuştur.
&nbsp;

*:exclamation: **Not:** Detaylar kod içerisinde, yorum satırlarında açıklanmıştır.*
&nbsp;

*:exclamation: **Not:** Oxxo.feature dosyasında belirtilen, 2 farklı; alıcı adı, alıcı telefon numarası, alıcı adresi, alıcının adres numarası, gönderenin ismi, gönderenin telefon numarası, gönderenin e-mail adresi ile test edilmiştir.*
&nbsp;

<div align ="center">
  
  # :four_leaf_clover: Sonuçlar :four_leaf_clover:
  &nbsp;
  
<a href="https://resimlink.com/o4HAaC" title="ResimLink - Resim Yükle"><img src="https://r.resimlink.com/o4HAaC.jpg" title="ResimLink - Resim Yükle" alt="ResimLink - Resim Yükle"></a>
</div align ="center">
 &nbsp;
 
 :star: [Ayrıca medium üzerinden yazdığım, "Page Object Model ile C# .NET Core Test Otomasyonu" yazısına göz atmanızı öneririm](https://medium.com/@iremuludirik/page-object-model-ile-c-net-core-test-otomasyonu-fa01d2da8b64) :star:
