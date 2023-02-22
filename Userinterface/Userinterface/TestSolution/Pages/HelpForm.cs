using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Userinterface.TestSolution.Pages
{
    public class HelpForm : Form
    {
        private static readonly By UniqueHelpFormLocator = By.XPath("//*[@class='help-form']");
        private static readonly IButton ButtonSendToBottom = ElementFactory.GetButton(By.XPath("//*[contains(@class,'help-form__send-to-bottom-button')]"), "Кнопка Send To Bottom");

        public HelpForm() : base(UniqueHelpFormLocator, "Форма помощи")
        {

        }

        public void ClickSendToBottomButton()
        {
            ButtonSendToBottom.Click();
        }
    }
}
