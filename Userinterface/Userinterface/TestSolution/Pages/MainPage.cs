using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Userinterface.TestSolution.Pages
{
    public class MainPage : Form
    {
        private static readonly By UniqueTimerLocator = By.XPath("//*[contains(@class,'logo__icon')]");
        private readonly ILabel TextTimer = ElementFactory.GetLabel(By.XPath("//*[contains(@class,'timer--center')]"), "Значение таймера");

        public MainPage() : base(UniqueTimerLocator, "Главная страница")
        {

        }

        public string GetTimerText()
        {
            return TextTimer.GetText();
        }
    }
}
