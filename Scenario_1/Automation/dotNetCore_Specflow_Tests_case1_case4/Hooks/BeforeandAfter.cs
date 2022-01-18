using BoDi;
using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;

namespace mizu_test
{
    [Binding]
    public class BeforeandAfter : TechTalk.SpecFlow.Steps {
        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {   
            if (driver == null)
            {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            }
            //Senaryo başlarında, chrome browser açıldı, pencere büyütüldü
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
            //Senaryo sonlarında, driver kapatıldı
        }
    }
}