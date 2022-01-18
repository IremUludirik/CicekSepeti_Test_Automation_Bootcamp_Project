#gerekli importlar yapıldı
from selenium.webdriver.common.by import By

class PriceControlPage():
    def __init__(self, driver): #driver self ile init diyerek çağrıldı
        self.driver = driver #driver yerine self.driver kullanılması için tanımlama yapıldı

    def test_price(self):
     self.driver.find_element(By.XPATH, "(// *[@class ='main-menu__text'])[16]").click() # flowers kategorisi seçildi
     self.driver.find_element(By.CSS_SELECTOR, ".js-filter-sort-item .icon-right-arrow").click() #sitede bulunan sort filtresine basılır.
     self.driver.find_element(By.CSS_SELECTOR, "[for='filter_sort_2']").click() #high to low filtresi seçilir.
     self.driver.execute_script("window.scrollTo(0,500)") #sayfa hafif aşağıya scroll edilir.

     arr =[] #aşağıda oluşturulan değerleri kullanabilmek için boş bir array atandı.
     element = 0 #for loopunda kullanılan element global tanımlandı.

     for i in range(20): #ilk 20 ürünün fiyatları karşılaştırıldı.
        element = element + 1 #ürün sırası 1 artarak ilerledi.

        #ürünün tam sayı olan kısmı text olarak seçildi ve virgül kullanıldığı için;
        #daha sonradan virgül kaldırılmak üzere virgülün iki tarafı ayrıldı.
        integer = (self.driver.find_element(By.XPATH, "(// *[@class ='price__integer-value'])[" + str(element) + "]").text).split(",")
        noCommaInt = integer[0] + integer[1] #burada virgülün iki tarafı da virgül olmaksızın birleştirildi.

        #ürün fiyatının küsüratlı kısmı seçildi
        decimal = self.driver.find_element(By.XPATH, "(// *[@class ='price__decimal-value-with-currency'])[" + str(element) + "]").text

        #ürünün virgülsüz olarak elde ettiğimiz tam kısmı ve küsürat kısmı toplandı
        totalPrice = noCommaInt + decimal

        #toplanılan ve loopa dahil olan her bir ürünün fiyatı, daha önce tanımladığımız array'in içerisine yerleştirildi.
        arr.append(totalPrice)

        #oluşturulan array büyükten küçüğe sıralandı.
        highToLowList = sorted(arr, reverse=True)

        #sıralı olan array ile, sitenin bize sunduğu array karşılaştırıldı ve eşit olması halinde true döndü.
        assert (highToLowList == arr) is True