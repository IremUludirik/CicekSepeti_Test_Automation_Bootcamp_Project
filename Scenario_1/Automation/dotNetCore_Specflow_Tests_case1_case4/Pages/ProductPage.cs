using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace mizu_test {
    [Binding]
public class ProductPage  :   BeforeandAfter {
    //BeforeandAfter sayfasından setup ve teardownları driver ile birlikte çekildi 
        public void dateselection()
        {   
            IWebElement calendar = driver.FindElement(By.XPath("//*[@id='productDetailSend']/div/div/div/div[2]/div[6]/div[4]/div[1]/p"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            var element = wait.Until(driver => calendar.Displayed);
            calendar.Click();
            //Takvime basıldı
            driver.FindElement(By.CssSelector("[data-day-month='25.01.2022']")).Click();
            //Gönderilecek gün seçildi
            SelectElement timelist = new SelectElement(driver.FindElement(By.XPath("//*[@id='productDetailSend']/div/div/div/div[2]/div[6]/div[4]/div[2]/select")));
            timelist.SelectByValue("2000330");
            //Gönderilecek günün saati seçildi
            IWebElement addbutton = driver.FindElement(By.XPath("//span[@class='product__action-button-text']"));
            WebDriverWait waitaddbutton = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
        }
        public void addtocartbutton()
        {   
            IWebElement addbutton = driver.FindElement(By.XPath("//span[@class='product__action-button-text']"));
            addbutton.Click();
            //Sepete ekle butonuna basıldı
        }
        public void guest()
        {   
            IWebElement guestbutton = driver.FindElement(By.CssSelector(".order-login__no-membership"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            var element = wait.Until(driver => guestbutton.Displayed);
            guestbutton.Click();
            //Misafir girişi yapıldı
        }
    }
}