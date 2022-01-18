<div align ="center">    
    
# :hibiscus: Cicek Sepeti Test Automation Bootcamp Project :hibiscus: 

</div>

:pushpin: **Senaryo 2: Signin ve signup endpointleri için entegrasyon testlerinin yazılması beklenmektedir..**
&nbsp;

- Bu senaryoda **Postman** ile çalışılmıştır.
- **Collection- JSON linki:** https://www.getpostman.com/collections/95a90ee45c09279ed0d7
- Her iki case için de **POST metodu** kullanılmıştır.
- **baseURL:** https://bootcampapi.techcs.io 
- Body :arrow_right: raw :arrow_right: JSON seçildi ve **{"email": "{{randomEmail}}", "password": "{{randomPassword}}"}** gönderildi.
- **Environments kısmında** her test için kullanılan başta baseurl olmak üzere, email ve password değerleri vardır.
&nbsp;
 
<div align ="center"><a href="https://resimlink.com/qg9AUBl" ><img src="https://r.resimlink.com/qg9AUBl.jpg"  alt="ResimLink - Resim Yükle" width="56%"></a></div align ="center"> 
&nbsp;

- Environment'de tanımlama yaptıktan sonra, değişkenler süslü parantez içerisinde kullanılmıştır : **{{ …VARIABLE…}}**
- **Pre-request Scriptlerde** environment için set ettiğmiz, testlere uyacak şekilde random email ve password gönderilmiştir.
&nbsp;

&nbsp;

:white_check_mark: **Sign up tesleri: /api/fe/v1/authorization/signup**
- **Alınması gereken kodlar ve mesajları:**
  - 200 user successfully signed-up
  - 409 user already signed-up
  &nbsp;
  
- **Testler**
	- Succesful
	- Same account
	- Big email size
	- Small email size
	- No email
	- Big password
	- Small password
	- No password
	- No email, no password
	&nbsp;

&nbsp;

  
:white_check_mark: **Sign in testleri: api/fe/v1/authorization/signin**
- **Alınması gereken kodlar ve mesajları**
	- 200 user successfully signed-in
	- 401 user submitted a wrong email or password
	 &nbsp;
	
- **Testler**
	- Succesful
	- Wrong email
	- No email
	- Wrong password
	- No password
	- No email, no password
  &nbsp;
  
  &nbsp;
	
:white_check_mark:**Newman Raporlama**
   - Node.js kuruldu 
   - Komut satırı modunda;
      - npm install npm --global
      - npm install –g newman
      - npm install –g newman-reporter-html
      - npm install –g newman-reporter-htmlextra
      - newman run <koleksiyonExportu>.json -e <environmentExportu>.json -r html
      - newman run <koleksiyonExportu>.json -e <environmentExportu>.json -r htmlextra
   - Adımları takip edilmiştir.

<div align ="center">
  
  # :four_leaf_clover: Sonuçlar :four_leaf_clover: 
  &nbsp;
  Newman Özet Rapor
  <div align ="center"><a href="https://imgyukle.com/f/2022/01/18/opaNdo.jpg" ><img src="https://imgyukle.com/f/2022/01/18/opaNdo.jpg"  alt="ResimLink - Resim Yükle" width="56%"></a></div align ="center"> 
&nbsp;
  
  HTML ilk iki test raporları
  <div align ="center"><a href="https://imgyukle.com/f/2022/01/18/opaNdo.jpg" ><img src="https://imgyukle.com/f/2022/01/18/opHapR.jpg"  alt="ResimLink - Resim Yükle" width="56%"></a></div align ="center">

