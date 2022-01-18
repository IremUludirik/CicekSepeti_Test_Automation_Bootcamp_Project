using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace mizu_test {
    [Binding]
public class HomePage  :   BeforeandAfter {     
    //BeforeandAfter sayfasından setup ve teardownları driver ile birlikte çekildi
        public void homepage()
        {
            driver.Navigate().GoToUrl("https://www.mizu.com/");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            wait.Until(driver => driver.FindElement(By.XPath("// *[@class ='icon-close']")));
            driver.FindElement(By.XPath("// *[@class ='icon-close']")).Click();
            driver.FindElement(By.XPath("// *[@class ='policy-popup__close icon-close js-policy-close']")).Click();
            //siteye gidildi. Pencere büyütüldü ve pop-uplar kapatıldı
        }
        
    }
}