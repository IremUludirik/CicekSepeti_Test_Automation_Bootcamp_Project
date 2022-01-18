#gerekli importlar yapıldı
import time
from selenium.webdriver.common.by import By

class ScrollControlPage():
    def __init__(self, driver): #driver self ile init diyerek çağrıldı
        self.driver = driver #driver yerine self.driver kullanılması için tanımlama yapıldı

    def test_scroll(self):
        #pageNum ve product for loop içerisinde kullanıldı. Bu parametreler global tanımlandı.
        pageNum = 0
        product = 0

        for i in range(10): #ilk 10 sayfa için for loop gerçekleştirildi
            time.sleep(3)
            pageNum = pageNum + 1 #sayfa numarası 1 artarak ilerler
            product = product + 60 #ürünler 60 artarak ilerler

            if (self.driver.current_url == "https://www.mizu.com/flowers"):
                #1. sayfanın url'inde 1 rakamı bulunmadığı için, sadece 1. sayfa için belirlenen sayfa dahilinde kontroller yapıldı

                #60 60 ilerleyen ürünlerden, 60. ürün görünene kadar scroll yapılır
                # 1. sayfa için 60.ürün tıklanabilme özelliğine dahil ise true döner. Varlığı kontrol edilmiş olur.

                self.driver.execute_script("arguments[0].scrollIntoView({behavior: 'smooth'});",
                        self.driver.find_element_by_xpath("/ html / body / main / div / div[4] / div["+str(product)+"]"))

                assert (self.driver.find_element(By.XPATH,
                                "/ html / body / main / div / div[4] / div[" + str(product) + "]")).click


            elif ((self.driver.current_url) == "https://www.mizu.com/flowers?page=" + str(pageNum)):
                #1. sayfa hariç diğer tüm sayfaların url'inde sayfa numaraları bulunmaktadır.
                # Bu yüzden url'in içerisindeki sayfa numaraları 2'den 10'a kadar loopa alındı.

                # 60 60 artarak ilerleyen ürünlerden, sayfa numarası ile senkronize bir şekilde,
                # 60'ın katları olarak son ürünler kontrol edilir.
                # Bu son ürün tıklanabilme özelliğine dahil ise true döner. Varlığı kanıtlanır.

                self.driver.execute_script("arguments[0].scrollIntoView({behavior: 'smooth'});",
                                           self.driver.find_element_by_xpath(
                                               "/ html / body / main / div / div[4] / div[" + str(product) + "]"))

                assert (self.driver.find_element(By.XPATH,
                                                 "/ html / body / main / div / div[4] / div[" + str(
                                                     product) + "]")).click