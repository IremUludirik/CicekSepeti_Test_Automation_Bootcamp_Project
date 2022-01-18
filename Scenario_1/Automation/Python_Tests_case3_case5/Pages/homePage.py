#gerekli importlar yapıldı
from selenium.webdriver.common.by import By

class HomePage():
    def __init__(self, driver): #driver self ile init diyerek çağrıldı
        self.driver = driver #driver yerine self.driver kullanılması için tanımlama yapıldı

    def test_flowers(self):
        self.driver.get("https://www.mizu.com/") #anasayfaya gidildi

        #pop-uplar kapatıldı
        self.driver.find_element(By.XPATH, "// *[@class ='icon-close']").click()
        self.driver.find_element(By.XPATH, "// *[@class ='policy-popup__close icon-close js-policy-close']").click()

        #flowers kategorisi seçildi
        self.driver.find_element(By.XPATH, "(// *[@class ='main-menu__text'])[16]").click()