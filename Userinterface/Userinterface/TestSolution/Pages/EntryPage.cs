using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Userinterface.TestSolution.Pages
{
    public class EntryPage : Form
    {
        private static readonly By UniqueEntryPageLocator = By.XPath("//*[contains(@class,'start__link')]");
        private readonly ILink HereLink = ElementFactory.GetLink(By.XPath("//*[contains(@class,'start__link')]"), "Гипертекст HERE");

        public EntryPage() : base(UniqueEntryPageLocator, "Страница входа в игру")
        {

        }

        public void ClickHereLink()
        {
            HereLink.Click();
        }
    }
}
