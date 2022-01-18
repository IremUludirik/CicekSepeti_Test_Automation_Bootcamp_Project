using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace mizu_test {
    [Binding]
public class SenderPage  :   BeforeandAfter {
    //BeforeandAfter sayfasından setup ve teardownları driver ile birlikte çekildi
        public void senderinfo(string sendername, string sendernumber, string senderemail)
        {
            IWebElement nameBox = driver.FindElement(By.CssSelector("#BuyerName"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            var element = wait.Until(driver => nameBox.Displayed);
            nameBox.SendKeys(sendername);
            //Gönderenin ismi yazıldı
            driver.FindElement(By.CssSelector(".js-emoji-characters[placeholder='Country']")).Click();
            //Gönderenin ülke no'su seçilmesi için kutucuğa basıldı
            driver.FindElement(By.XPath("//*[@id='billing-form']/div[4]/div/div[1]/div[2]/div/div[2]/div/div[1]")).Click();          
            //Gönderenin ülke no'su seçildi
            driver.FindElement(By.CssSelector("#PhoneNumber")).SendKeys(sendernumber);
            //Gönderenin telefon numarası yazıldı
            driver.FindElement(By.CssSelector("#Email")).SendKeys(senderemail);
            //Gönderenin e-mail adresi yazıldı
        }

        public void nextButton()
        {
            driver.FindElement(By.CssSelector(".order-right > div:nth-of-type(1) > .btn")).Click();
            //Sayfa geçişi için next butonuna basıldı
        }
    }
}