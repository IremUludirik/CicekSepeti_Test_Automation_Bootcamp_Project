package Pages;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.support.ui.ExpectedConditions;

public class PersonalizationPage extends BasePage {
//BasePage'den driver ve wait fonksiyonu çağırıldı
    public PersonalizationPage(WebDriver driver) {
        super(driver);
    }

    public void personalizationAndAddBasket() throws InterruptedException {

        driver.findElement(By.cssSelector("[data-module-id='2']")).sendKeys("Portarretratos de cristal PERSONALIZADO CANCIÓN");
        //Aranacak ürün ismi search box'a yazıldı
        driver.findElement(By.xpath("(//*[@class='live-search__text-find'])[1] ")).click();
        wait.until(ExpectedConditions.visibilityOfElementLocated(By.cssSelector(".products__item:nth-child(2) .products__item-img")));
        driver.findElement(By.cssSelector(".products__item:nth-child(2) .products__item-img")).click();
        //Çıkan ürünlerden istenilen ürün seçildi

        wait.until(ExpectedConditions.visibilityOfElementLocated(By.xpath("//*[@class='product__action-button-text']"))).click();
        //Add to Cart butonuna basıldı

        wait.until(ExpectedConditions.visibilityOfElementLocated(By.cssSelector(".form-control"))).sendKeys("cicek sepeti bootcamp");;
        // kişiselleştirme için text girildi

        wait.until(ExpectedConditions.visibilityOfElementLocated(By.xpath("//*[@id=\"customProduct-1530324798\"]/div[2]/div/div[2]/div/div[3]/div/span")));
    }
}

