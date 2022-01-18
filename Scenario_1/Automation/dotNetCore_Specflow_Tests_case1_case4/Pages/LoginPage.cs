using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace mizu_test {
    [Binding]
public class LoginPage  :   BeforeandAfter { 
    //BeforeandAfter sayfasından setup ve teardownları driver ile birlikte çekildi
        public void loginpage()
        {
            IWebElement accountPart = driver.FindElement(By.CssSelector(".header__right-col .user-menu__icon--account"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            var element = wait.Until(driver => accountPart.Displayed);
            Actions action = new Actions(driver);
            action.MoveToElement(accountPart).Perform();
            driver.FindElement(By.CssSelector(".header__right-col .icon-login")).Click();
            //signin logosunun üzerine gelinip, signin'e basılarak login sayfasına gidildi.
        }

        public void Ienterthformations(string email, string password)
        {
            IWebElement emailBox = driver.FindElement(By.Id("EmailLogin"));
            IWebElement passwordBox = driver.FindElement(By.CssSelector("#Password"));
            emailBox.SendKeys(email);
            passwordBox.SendKeys(password);
            //email ve password kutularına feature dosyasında belirtilen email ve password yazıldı.
        }

        public void SignInbutton()
        {
            IWebElement signInButton = driver.FindElement(By.CssSelector(".login__btn"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            wait.Until(driver => signInButton.Displayed);
            signInButton.Click();
            //giriş yap butonuna basıldı.
        }

        public void MyAccountbutton()
        {
            IWebElement myAccount = driver.FindElement(By.CssSelector(".header__right-col .user-menu__item--account .user-menu__title"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            wait.Until(driver => myAccount.Displayed);
            Assert.That(myAccount.Text, Is.EqualTo("My Account"));
            //My Account yazısı kontrol edildi.
        }

        public void logout()
        {
            IWebElement logOutButton = driver.FindElement(By.XPath("(//*[@class='icon-close user-menu__log-out-icon'])[1]"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            wait.Until(driver => logOutButton.Displayed);
            logOutButton.Click();
            //Bir sonraki testin başarılı bir şekilde gerçekleşmesi için çıkış yapıldı.
        }
    }
}
