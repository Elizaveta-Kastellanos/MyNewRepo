using Aquality.Selenium.Core.Elements;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using Userinterface.TestSolution.Elements;
using Userinterface.TestSolution.Models;

namespace Userinterface.TestSolution.Pages
{
    public class LoginPage : Form
    {
        private static readonly By UniqueLoginPageLocator = By.XPath("//*[contains(@class,'login-form__terms-conditions')]");
        private readonly ICheckBox PrivacyPolicyCheckbox = ElementFactory.GetCheckBox(By.XPath("//*[contains(@class,'checkbox__box')]"), "Чекбокс Terms & Conditions");
        private readonly IButton NextButton = ElementFactory.GetButton(By.XPath("//*[contains(@class,'button--secondary')]"), "Кнопка Next");
        private readonly Dropdown DomentsDropdown = new Dropdown(By.XPath("//*[contains(@class,'dropdown__field')]"), "Выпадающий список с выбором домена");
        private readonly IComboBox WaitToOpencombox = ElementFactory.GetComboBox(By.XPath("//*[contains(@class,'dropdown open dropdown--gray')]"), "Жду открытие комбобокса");
        private ITextBox LogingInput(string titleInput) => ElementFactory.GetTextBox(By.XPath($"//*[contains(@placeholder,'{titleInput}')]"), $"Поле ввода {titleInput}");

        public LoginPage() : base(UniqueLoginPageLocator, "Первая карточка и страница ввода логина, пароля и email")
        {

        }

        public void EnterTextInInput(string regisrationValue, string titleInput)
        {
            LogingInput(titleInput).ClearAndType(regisrationValue);
        }

        public void SelectItemDropdown(int text)
        {
            DomentsDropdown.Click();
            WaitToOpencombox.State.WaitForNotExist();
            DomentsDropdown.SelectItem(text);
        }

        public void ClickPrivacyPolicyCheckbox()
        {
            PrivacyPolicyCheckbox.Click();
        }

        public void ClickNextButton()
        {
            NextButton.Click();
        }

        public int GetCountItemDomenDropdown()
        {
            return DomentsDropdown.GetCountItem();
        }
    }
}
