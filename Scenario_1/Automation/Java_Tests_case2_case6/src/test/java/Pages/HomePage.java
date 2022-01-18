package Pages;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.support.ui.ExpectedConditions;

//BasePage'den driver çekildi
public class HomePage extends BasePage {
    public HomePage(WebDriver driver) {
        super(driver);
    }

    //Test burada başlıyor
    public void mizu () {
        driver.get("https://www.mizu.com/en-mx/"); //anasayfaya gidildi

        //pop-up'lar görününce kapatıldı
        wait.until(ExpectedConditions.visibilityOfElementLocated(By.xpath("// *[@class ='icon-close']"))).click();
        wait.until(ExpectedConditions.visibilityOfElementLocated
                (By.xpath("// *[@class ='policy-popup__close icon-close js-policy-close']"))).click();
        wait.until(ExpectedConditions.visibilityOfElementLocated(By.cssSelector("[data-module-id='2']")));
    }
}


