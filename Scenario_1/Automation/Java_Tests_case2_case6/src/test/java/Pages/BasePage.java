package Pages;
import org.openqa.selenium.JavascriptExecutor;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.support.ui.WebDriverWait;

public class BasePage {
//Driver ve wait fonksiyonu burada tanımlandı
    public WebDriver driver;
    public WebDriverWait wait;
    JavascriptExecutor js = (JavascriptExecutor) driver;

    public BasePage(WebDriver driver) {
        this.driver = driver;
        wait = new WebDriverWait(driver, 5);
    }
}
