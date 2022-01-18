<div align ="center">   
    
# :hibiscus: Cicek Sepeti Test Automation Bootcamp Project :hibiscus: 
  

  
</div>

:pushpin: **Senaryo 1.2: Otomasyon yazılması.**
&nbsp;

<div align ="center">
  
# .netCore Spectflow Tests- Case 1 & Case 4 
</div align ="center">

:fish_cake: Testlerin çalışması için, **VSCode'un kendi terminalinden "dotnet test"** yazılması gerekmektedir.
&nbsp;

:fish_cake: **BeforeandAfter:** Driver burada tanımlanmıştır. BeforeScenario ve AfterScenario dahilinde browser açılımı ve kapanışı yer almaktadır. Senaryolardan önce ve sonra çalışır.
&nbsp;

:fish_cake: **HomePage:** "https://www.mizu.com/" sayfasına gidilir. Pencere büyütülerek pop-up'lar kapatılır. Senaryo başında çalışır.
&nbsp;

<div align ="center">
  
# :dart: Case 1 :dart:
</div align ="center">
:fish_cake: https://www.mizu.com/login sayfasında kullanıcı adı ve şifre başarılı şekilde sign in olunması.
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


*:exclamation: **Not:** Login.feature dosyasında belirtilen, 3 farklı email ve password ile test edilmiştir.*
&nbsp;

