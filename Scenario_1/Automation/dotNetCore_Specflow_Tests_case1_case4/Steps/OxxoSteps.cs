using TechTalk.SpecFlow;
	
namespace mizu_test {
	[Binding]
public class OxxoSteps {
    //Oxxo.feature dosyasında belirlenen adımlara göre, sırasıyla ilgili sayfalardan ve fonksiyonlardan stepler çekilerek, senaryo gerçekleştirildi
    HomePage homePage = new HomePage();
    FlowersPage flowersPage = new FlowersPage();
    ProductPage productpage = new ProductPage();
    OrderPage orderpage = new OrderPage();
    SenderPage senderpage = new SenderPage();
    PaymentPage paymentpage = new PaymentPage();

        [Given(@"I am on home page")]
        public void Iamonhomepage() { homePage.homepage(); }

        [Given(@"I am on flowers page")]
        public void Iamonflowerspage() { flowersPage.flowerspage(); }

        [When(@"I enter the shipping address for mexico city")]
        public void Ientertheshippingaddressformexicocity() { flowersPage.shippingAdress(); }

        [When(@"I click the first product")]
        public void Iclickthefirstproduct() { flowersPage.firstelement(); }

        [When(@"I set the shipping date and time on product page")]
        public void Isettheshippingdateandtimeonproductpage() { productpage.dateselection(); }

        [When(@"I add the product to the cart")]
        public void Iaddtheproducttothecart() { productpage.addtocartbutton(); }

        [When(@"I click the guest checkout button")]
        public void Iclicktheguestcheckoutbutton() { productpage.guest(); }

        [When(@"I enter the (.*), (.*), (.*), (.*), postcode and choose deliverily location on order page")]
        public void Ienterthenamenumberaddressinteriornopostcodeandchoosedeliverilylocationonorderpage (string name, string number, string address, string interiorno) 
        { orderpage.orderinfo(name, number, address, interiorno); }

        [When(@"I click the next buttons")]
        public void Iclickthenextbuttons() { orderpage.nextButtons();}

        [When(@"I enter the (.*), (.*), (.*) and select the country on sender page")]
        public void Ienterthesendernamesendernumbersenderemailandselectthecountrysenderpage (string sendername, string sendernumber, string senderemail)
        { senderpage.senderinfo(sendername, sendernumber, senderemail); }

        [When(@"I click the next button")]
        public void Iclickthenextbutton() { senderpage.nextButton();}

        [When(@"I choose the OXXO and accept the conditions for payment on payment page")]
        public void IchoosetheOXXOandaccepttheconditionsforpaymentonpaymentpage() { paymentpage.oxxo(); }

        [When(@"I click the pay button")]
        public void Iclickthepaybutton() { paymentpage.pay(); }

        [Then(@"I see confirmation message")]
        public void Iseeconfirmationmessage() { paymentpage.messageBox(); }
    }
}