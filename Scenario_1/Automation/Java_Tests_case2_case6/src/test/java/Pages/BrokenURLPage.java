package Pages;

import org.openqa.selenium.WebDriver;

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

import org.jsoup.Jsoup;
import org.jsoup.nodes.Document;
import org.jsoup.nodes.Element;
import org.jsoup.select.Elements;

public class BrokenURLPage extends BasePage {
    //BasePage'den driver ve wait fonksiyonu çağırıldı
    public BrokenURLPage(WebDriver driver) {
        super(driver);
    }

    public void brokenURLforCat() {
        //jsoup ile scrape edildi
        Document doc;
        try {
            String baseURL = "https://www.mizu.com"; //baseURL belirlendi
            doc = Jsoup.connect("https://www.mizu.com/en-mx/").get();

            //baseURL'deki bütün linkler çekildi
            Elements links = doc.select("a[href]");
            for (Element link : links) {
                // Linkler içerisindeki başlıklar alındı

                //Gelen bazı linklerde baseURL tespit edilmediği için, eğer link baseURL'e sahip değilse eklendi
                if (link.attr("href").contains(baseURL)) {
                    filter(link.text(), link.attr("href"));
                } else {
                    filter(link.text(), baseURL + link.attr("href"));
                }
            }

            for (String link : linkList) {
                //linkList içerisindeki linklerden bazıları birden fazla olduğu için,
                // birden fazla tekrar eden linkleri sadece bir kere saydırıp notDoublelink listesine eklendi
                if (!notDublelink.contains(link)) {
                    notDublelink.add(link);
                }
            }

            //System.out.println(notDublelink);

        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    //linkList ve notDoublelink adında iki adet boş array açıldı
    public List<String> linkList = new ArrayList<String>();
    public List<String> notDublelink = new ArrayList<String>();
    //Dönen linklerden kategori olmayan linklerin hepsi çıkarıldı
    public String notCat = "contact-us:https://www.mizu.com/en-mx/contact-us " + "faq:https://www.mizu.com/en-mx/faq " + "about-us:https://www.mizu.com/en-mx/about-us " + "sitemap:https://www.mizu.com/en-mx/sitemap " + "refund-policy:https://www.mizu.com/en-mx/refund-policy " + "delivery-policy:https://www.mizu.com/en-mx/delivery-policy " + "cancellation-policy:https://www.mizu.com/en-mx/cancellation-policy " + "cookie-policy:https://www.mizu.com/en-mx/cookie-policy " + "contact-us:https://www.mizu.com/contact-us " + "faq:https://www.mizu.com/faq " + "about-us:https://www.mizu.com/about-us " + "sitemap:https://www.mizu.com/sitemap " + "refund-policy:https://www.mizu.com/refund-policy " + "delivery-policy:https://www.mizu.com/delivery-policy " + "cancellation-policy:https://www.mizu.com/cancellation-policy " + "cookie-policy:https://www.mizu.com/cookie-policy" + "sell-on-mizu:https://www.mizu.com/en-mx/sell-on-lolaflora" + "colombia:https://www.mizu.com/en-co/" + "spain:https://www.mizu.com/en-es/" + "mindful-marketing-movement:https://www.mizu.com/en-mx/mindful-marketing" + " legal:https://www.mizu.com/en-mx/terms" + "terms-and-conditions:https://www.mizu.com/en-mx/terms" + "privacy-policy---gdpr:https://www.mizu.com/en-mx/privacy" + " help:https://www.mizu.com#collapse-0" + "mindful-marketing-movement:https://www.mizu.com/mindful-marketing" + " legal:https://www.mizu.com#collapse-1" + "terms-and-conditions:https://www.mizu.com/terms" + "privacy-policy---gdpr:https://www.mizu.com/privacy, germany:https://www.mizu.com/en-de/" + "vietnam:https://www.mizu.com/en-vn/" + " help:https://www.mizu.comhttps://assistant.mizu.com";

    public void filter(String linkText, String linkAttr) {
        //Dönen linklerin; başlıkları boş olanlar, link sonlarında "(0)" ifadesi bulunduranlar, ve birden fazla
        //sayılan linkler çıkartıldı
        if (!linkText.equals("") && !linkAttr.contains("(0)") && !notCat.contains(linkAttr)) {
            //linkin başlığı ile link sonundaki başlığı temsil eden yazı kontrol edilebilmesi için
            //linkin sonundaki başlığa denk gelen yazı küçük harflere çevrilip, boşluklar yerine "-" konuldu
            linkText = linkText.toLowerCase().replace(" ", "-");
            //Temizlenen linkler ve düzenlenen başlıklar linkList array'ine başlık:link şeklinde eklendi
            linkList.add(linkText + ":" + linkAttr);
        }
    }
    //Böylelikle istediğimiz kontroller adım adım yapıldı
}