<div align ="center">   
    
# :hibiscus: Cicek Sepeti Test Automation Bootcamp Project :hibiscus: 

</div>

:pushpin: **Senaryo 3: https://www.cicek.com header da bulunan search modülü ve arama sonrası gidilen sonuçların listelendiği listeleme sayfasının yük altındaki davranışını incelemek adına yük testleri ve senaryolarına ihtiyaç vardır. İlgili durum için test senaryosunun yazılması. JMeter kullanarak, ilgili senaryoları kodlayın. (1 kullanıcı yeterli).**
&nbsp;
- Apache JMeter, çeşitli uygulamaların performansını analiz etmek ve ölçmek için web uygulamalarına odaklanarak bir yük test aracı olarak kullanılabilen bir Apache projesidir.
- Yük testi: Sunulan uygulamanın belirli bir yük altında nasıl davrandığını (cevaplarda gecikme süresi, kullanıcı deneyimi, vb) gözlemleyen test türüdür.

<div align ="center"><img src="https://imgyukle.com/f/2022/01/18/opOtQp.jpg" alt="opOtQp.jpg" border="0"></div>
&nbsp;
   
**:white_check_mark: Test Plan :arrow_right: Sağ Tık :arrow_right: Add :arrow_right: Config Element** 
- **HTTP Request Defaults:** Her istek için gidilecek sayfanın base URL'i tanımlanmıştır: www.cicek.com
- **User Defined Variables:** Kullanılacak değişkenler tanımlanmıştır: keyForSearchBox-> ${keyForSearchBox}
- **HTTP Cookie Manager:** Oluşacak cookiler burada toplanır.
- **CSV Data Set Config:** Key for Search Box için kullanılacak data seti bir csv dosyası içerisine kaydedilir. Ve bu ksımda dosyanın pathi, nasıl ayrılacağı (;), data setindeki ilk satırın atlanıp atlanmayacağı gibi durumlar belirlenir. 8 adet data girilmiştir.
<div align ="center"><img src="https://imgyukle.com/f/2022/01/18/opO8Z6.jpg" alt="opO8Z6.jpg" border="0" ></div>
    &nbsp;
    
*:exclamation: **Not:** 8 farklı data kullanılacağı için, aynı senaryo 8 kere dönecektir.*
 &nbsp;
 
 &nbsp;
 
 **:white_check_mark: Test Plan :arrow_right: Sağ Tık :arrow_right: Add :arrow_right: Threads (Users) :arrow_right: Thread Group**
- **HTTP(S) Test Script Recorder:** Burada HTTPS ile çalışma yapıldığı için, kullanılan browser'ın **sertifika** ayarlarından Jmeter'in sertifikasını yüklenmiştir.
- **Cicek.com Recorder Result:** Recording Controller'dır. Proxy görevi yapar. Bağlantı kurarak kaydeder ve toplar. Burada HTTP(S) Test Script Recorder kısmında site üzerinde kayıt edilen tüm network ağları bu dosya içine kaydolur.
- **Search Box Scanerios:**
    - **Home Page:** cicek.com'un anasayfası (Path:/)
    - **Writing Key/Suggest List:** Arama kutucuğuna kelime yazıldığında, öneri listesi oluşur. (Path:/Suggest/Get)
    - **Search:** Kelimeyi aratma yapar (Path:/Arama)
    - **Key Result List:** Aratılan kelime için çıkan sonuçlar (Path:/Catalog/AjaxCategory) 
    - **Think Time:** Kullanıcılar için düşünme süresi tanımlanmıştır.
    - **Listener:** Sampler’lar tarafından yapılan istekler ve bu isteklere sunucu tarafından verilen cevapların özelliklerinin teker teker, toplu veya kümüle bir şekilde kaydedilmesi işlevini Listener’lar yerine getirmektedir. (view results tree, assertion results, graph results, summary report).
	    &nbsp;
 
 &nbsp;
   

**:white_check_mark: Her bir senaryo adımı için yapılan assertionlar:**
- Size assertion
-  Size assertion
- Duration assertion
- Response code assertion
- Response code message assertion
- URL assertion
- Response header assertion
- Response body assertion
- Request header assertion
- Request body assertion
- Ignore status (Sadece hata beklenen datalar için kullanıldı)
- Json assertion for key (Sadece Writing Key/ Suggest Manager için kullanıldı)
<img src="https://imgyukle.com/f/2022/01/18/opOFgy.jpg" alt="opOFgy.jpg" border="0">
&nbsp;
 
 &nbsp;
   
 **:white_check_mark: Jmeter raporlama:** komut satırı modunda
 - **jmeter -n -t “jmeter dizininin kaydedildiği yer.jmx” -l “sonuç dosyasının oluşturulacağı yer.csv” -e -o “sonuçların atanacağı dosyanın oluşturulacak konumu”** ile çalıştırılmıştır.



<div align ="center">
  
  # :four_leaf_clover: Sonuçlar :four_leaf_clover: 
  Results ve Screenshots klasöründe detayları ve daha fazlası bulunmaktadır.
  &nbsp;
  
 <img src="https://imgyukle.com/f/2022/01/18/opOOcI.jpg" alt="opOOcI.jpg" border="0">
<img src="https://imgyukle.com/f/2022/01/18/opOjef.jpg" alt="opOjef.jpg" border="0">
<img src="https://imgyukle.com/f/2022/01/18/opONJ1.jpg" alt="opONJ1.jpg" border="0">
<img src="https://imgyukle.com/f/2022/01/18/opOapH.jpg" alt="opOapH.jpg" border="0">
<img src="https://imgyukle.com/f/2022/01/18/opOppt.jpg" alt="opOapH.jpg" border="0">
<img src="https://imgyukle.com/f/2022/01/18/opOckG.jpg" alt="opOckG.jpg" border="0">


