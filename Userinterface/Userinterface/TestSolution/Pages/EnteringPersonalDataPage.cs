using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Userinterface.TestSolution.Pages
{
    public class EnteringPersonalDataPage : Form
    {
        private static readonly By UniqueThirdCardPageLocator = By.XPath("//*[contains(@class,'personal-details__td-value')]");

        public EnteringPersonalDataPage() : base(UniqueThirdCardPageLocator, "Третья карточка и страница для ввода персональных данных")
        {

        }
    }
}
