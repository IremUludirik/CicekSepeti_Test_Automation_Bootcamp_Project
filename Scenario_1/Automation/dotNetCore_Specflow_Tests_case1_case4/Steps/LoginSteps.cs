using TechTalk.SpecFlow;

namespace mizu_test {
    [Binding]
public class LoginSteps : LoginPage {
    //LoginPage'den stepler çekildi
    HomePage homePage = new HomePage();
    //HomePage'den stepler çekildi

    //Login.feature dosyasında belirlenen adımlara göre, sırasıyla ilgili sayfalardan ve fonksiyonlardan stepler çekilerek, senaryo gerçekleştirildi
        [Given(@"Firstly I am on home page")]
        public void FirstlyIamonhomepage() { homePage.homepage(); }

        [Given(@"I am on login page")]
        public void Iamonloginpage() { loginpage(); }

        [When(@"I enter the (.*) and (.*) information")]
        public void Ientertheemailandpasswordinformations(string email, string password) 
        { Ienterthformations(email, password); }

        [When(@"I click Sign In button")]
        public void IclickSignInbutton() { SignInbutton(); }

        [Then(@"I see My Account button")]
        public void IseeMyAccountbutton() { MyAccountbutton(); }

		[Then(@"I log out")]
        public void Ilogout() { logout(); }
    }
}

