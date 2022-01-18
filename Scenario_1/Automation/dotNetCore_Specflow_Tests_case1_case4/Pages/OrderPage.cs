using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace mizu_test {
    [Binding]
public class OrderPage  :   BeforeandAfter {
    //BeforeandAfter sayfasından setup ve teardownları driver ile birlikte çekildi
        public void orderinfo(string name, string number, string address, string interiorno)
        {
            IWebElement nameBox = driver.FindElement(By.CssSelector("[placeholder='Recipient Name']"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            var element = wait.Until(driver => nameBox.Displayed);
            nameBox.SendKeys(name);
            //Gönderilecek kişinin ismi yazıldı
            driver.FindElement(By.CssSelector("[placeholder='Recipient Phone Number']")).SendKeys(number);
            //Gönderilecek kişinin ismi telefon numarası yazıldı
            driver.FindElement(By.CssSelector(".js-address-line")).SendKeys(address);
            //Gönderilecek yerin adresi yazıldı
            driver.FindElement(By.CssSelector("[placeholder='Exterior-Interior No.']")).SendKeys(interiorno);
            //Gönderilecek yerin adres numarası yazıldı
            driver.FindElement(By.CssSelector("[placeholder='Postcode of Recipient']")).SendKeys("01000");
            //Gönderilecek yerin posta kodu yazıldı
            var placeBox = "/html/body/main/div/form/div/div[1]/div/div/div[3]/div[5]/div";
            driver.FindElement(By.XPath(placeBox)).Click();
            //Gönderilecek yerin ismini seçeceğimiz kutucuğa basıldı
            IWebElement placeType = driver.FindElement(By.XPath(placeBox + "/div[2]/div/div[1]"));
            WebDriverWait waitplaceType = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            var placeTypeElmnt = wait.Until(driver => placeType.Displayed);
            placeType.Click();
            //Gönderilecek yerin ismi seçildi
        }

        public void nextButtons()
        {
            driver.FindElement(By.CssSelector(".order-right > div:nth-of-type(1) .order-next-button__text")).Click();
            driver.FindElement(By.CssSelector(".order-next-button--before-summary")).Click();
            //Sayfalar arası geçiş için next butonlarına basıldı
        }
    }
}