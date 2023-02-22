using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Userinterface.TestSolution.Pages
{
    public class CookiesForm : Form
    {
        private static readonly By UniqueFormCookieLocator = By.XPath("//*[contains(@class,'cookies')]");
        private static readonly IButton NotReallyNoButton = ElementFactory.GetButton(By.XPath("//*[contains(@class,'button--transparent')]"), "Кнопка Not Really, No");

        public CookiesForm() : base(UniqueFormCookieLocator, "Форма с куками")
        {

        }

        public void ClickNotReallyNoButton()
        {
            NotReallyNoButton.Click();
        }
    }
}
