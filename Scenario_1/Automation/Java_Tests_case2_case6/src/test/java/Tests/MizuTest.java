package Tests;
import Pages.BrokenURLPage;
import Pages.HomePage;
import Pages.PersonalizationPage;
import Pages.RobotTest;
import org.testng.annotations.Test;
import java.awt.*;

public class MizuTest extends BaseTest {
//Testlerin çalışması için sayfalardan gerekli fonksiyonlar çekildi
    @Test(priority = 1)
    public void homeTest() {
        HomePage homePage = new HomePage(driver);
        homePage.mizu();
    }

    @Test(priority = 2)
    public void personalizationTest() throws InterruptedException {
        PersonalizationPage personalizationPage = new PersonalizationPage(driver);
        personalizationPage.personalizationAndAddBasket();

        RobotTest robotTest = new RobotTest(driver);
        robotTest.robotclassTest();
        robotTest.confirm();
    }


    @Test(priority = 3)
    public void brokenURLTest() {
        BrokenURLPage brokenURLPage = new BrokenURLPage(driver);
        brokenURLPage.brokenURLforCat();
    }
}

