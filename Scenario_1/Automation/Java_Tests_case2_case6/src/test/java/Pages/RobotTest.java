package Pages;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.testng.Assert;
import java.awt.*;
import java.awt.datatransfer.Clipboard;
import java.awt.datatransfer.StringSelection;
import java.awt.event.KeyEvent;

public class RobotTest extends BasePage {
    //BasePage'den driver ve wait fonksiyonu çağırıldı
    public String filePath = "C:\\Users\\irem6.DESKTOP-8MQ14NE\\OneDrive\\Masaüstü\\Yeni klasör\\me.jpg";
    public RobotTest(WebDriver driver) {
        super(driver);
    }

    public void robotclassTest() throws InterruptedException {
        //Görsel yüklenmesi
        wait.until(ExpectedConditions.visibilityOfElementLocated(By.xpath("//*[@id=\"customProduct-1530324798\"]/div[2]/div/div[2]/div/div[3]/div/span")));
        driver.findElement(By.xpath("//*[@class='custom-image__img-container--placeholder']")).click();
        //Görseli yüklemek için, yüklenecek yere basıldı
        uploadFileWithRobot(filePath); //Görselin yolu ile birlikte aşağıdaki robot komutları çalıştırıldı
    }

        //Robot komutlarının kullanımı
    public void uploadFileWithRobot(String imagePath) throws InterruptedException {
        StringSelection stringSelection = new StringSelection(imagePath);
        Clipboard clipboard = Toolkit.getDefaultToolkit().getSystemClipboard();
        clipboard.setContents(stringSelection, null);

        Robot robot = null;

        try {
            robot = new Robot();
        } catch (AWTException e) {
            e.printStackTrace();
        }

        robot.delay(250);
        robot.keyPress(KeyEvent.VK_ENTER);
        robot.keyRelease(KeyEvent.VK_ENTER);
        robot.keyPress(KeyEvent.VK_CONTROL);
        robot.keyPress(KeyEvent.VK_V);
        robot.keyRelease(KeyEvent.VK_V);
        robot.keyRelease(KeyEvent.VK_CONTROL);
        robot.keyPress(KeyEvent.VK_ENTER);
        robot.delay(150);
        robot.keyRelease(KeyEvent.VK_ENTER);
    }

    public void confirm() {
        wait.until(ExpectedConditions.visibilityOfElementLocated(By.cssSelector("[name='confirmation']"))).click();
        //confirmation kutucuğu checklendi
        driver.findElement(By.cssSelector("#productDetailSendMobile > div:nth-of-type(3) .order-next-button__text")).click();
        //next butonuna basıldı
        WebElement cartSummary = driver.findElement(By.cssSelector(".order-summary__heading"));
        Assert.assertTrue(cartSummary.getText().contains("Order Summary"));
        //Sepetime eklendiği kontrol edildi
    }
}

