package Tests;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import org.testng.annotations.AfterClass;
import org.testng.annotations.BeforeClass;

public class BaseTest {

    public WebDriver driver;

    @BeforeClass
    public void setup() {
        //Testlerden önce çalışması için browser tanımı ve stup yapılıp pencere büyütüldü
        System.setProperty("webdriver.chrome.driver", "C:\\Users\\irem6.DESKTOP-8MQ14NE\\Downloads\\chromedriver_win32 (1)\\chromedriver.exe");
        driver = new ChromeDriver();
        driver.manage().window().maximize();
    }

    @AfterClass
    //Test bitiminde driverın kapatılması sağlandı
    public void teardown() {
        driver.quit();
    }
}
