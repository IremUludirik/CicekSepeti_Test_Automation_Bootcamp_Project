using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace mizu_test {
    [Binding]
public class FlowersPage  :   BeforeandAfter { 
    //BeforeandAfter sayfasından setup ve teardownları driver ile birlikte çekildi
        public void flowerspage()
        {
            IWebElement flowersCat = driver.FindElement(By.XPath("(//*[@class='main-menu__text'])[16]"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            var element = wait.Until(driver => flowersCat.Displayed);
            flowersCat.Click();
            //Kategori menüsü üzerinden flowers kategorisine basıldı
        }

        public void shippingAdress()
        {
            IWebElement addressBox = driver.FindElement(By.CssSelector(".district-search-button__text"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            var element = wait.Until(driver => addressBox.Displayed);
            addressBox.Click();
            //Gönderim adresi kutucuğuna basıldı
            driver.FindElement(By.XPath("//*[@id='district-search-0']/input")).SendKeys("mexico city");
            //Gönderim adresi kutucuğuna mexico city yazıldı
            IWebElement address = driver.FindElement(By.XPath("//*[@id='district-search-0']/div[3]/ul/li[5]/a"));
            WebDriverWait waitadress = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            var adresselement = waitadress.Until(driver => address.Displayed);
            address.Click();
            //ardından çıkan liste üzerinden seçildi
            IWebElement firstelement = driver.FindElement(By.XPath("/html/body/main/div/div[4]/div[1]/div/div/a/div[1]"));
            WebDriverWait waitFirstElemnt = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            
        }

        public void firstelement()
        {  
            IWebElement firstelement = driver.FindElement(By.XPath("/html/body/main/div/div[4]/div[1]/div/div/a/div[1]"));
            firstelement.Click();
            //Sayfada çıkan ilk elemente basıldı       
        }
    }
}