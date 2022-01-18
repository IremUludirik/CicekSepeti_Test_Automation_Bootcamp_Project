using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace mizu_test {
    [Binding]
public class PaymentPage  :   BeforeandAfter {
    //BeforeandAfter sayfasından setup ve teardownları driver ile birlikte çekildi 
        public void oxxo()
        {
            IWebElement oxxo = driver.FindElement(By.CssSelector("[for='radio31']"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            var element = wait.Until(driver => oxxo.Displayed);
            oxxo.Click();
            //OXXO ile ödeme için OXXO'ya basıldı

            IWebElement checkBox = driver.FindElement(By.CssSelector(".black-checkbox"));
            WebDriverWait waitcheckBox = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            var checkBoxelement = wait.Until(driver => checkBox.Displayed);
            checkBox.Click();
            //Şartlar kutucuğu checklendi
        }

        public void pay()
        {
            driver.FindElement(By.CssSelector("[name='nextstep']")).Click();
            IWebElement messageBox = driver.FindElement(By.CssSelector(".thanks__message-text"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            //Ödeme yap butonuna basıldı
        }

        public void messageBox()
        {
            IWebElement messageBox = driver.FindElement(By.CssSelector(".thanks__message-text"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            wait.Until(driver => messageBox.Displayed);
            Assert.That(messageBox.Text, Is.EqualTo("We have received your order and will start to prepare it as soon as you make the payment!"));
            //Onaylama yazısı kontrol edildi       
        }
    }
}   