#gerekli importlar yapıldı
import pytest
from selenium import webdriver
from Pages.homePage import HomePage
from Pages.scrollControlPage import ScrollControlPage
from Pages.priceControlPage import PriceControlPage

#testlerin dahil olduğu bir class açıldı
class TestMizu():
    @classmethod
    @pytest.fixture() #bu metod sayesinde setup ve teardown düzenlendi

#setup ile driverımız tanımlandı
    def test_setup(self):
        global driver #driverımız başka dosyalarda da kullanılabilsin diye global tanımlandı
        driver = webdriver.Chrome(
            executable_path=r"C:\Users\irem6.DESKTOP-8MQ14NE\OneDrive\Masaüstü\chromedriver_win32\chromedriver.exe")
        driver.implicitly_wait(8) #driver açılması için süre verildi
        driver.maximize_window() #pencere büyütüldü

#ilk test, setup ile başladı.
#testler bulundukları sayfalardan, driver ile birlikte çekildi.
    def test_flowers(self, test_setup):
        # click flowers
        home = HomePage(driver)
        home.test_flowers()

    def test_scroll(self):
        # scroll page
        find = ScrollControlPage(driver)
        find.test_scroll()

    def test_price(self):
         # high to low
         price = PriceControlPage(driver)
         price.test_price()

    @classmethod
    def tear_down(self):
        driver.close()
        driver.quit()
