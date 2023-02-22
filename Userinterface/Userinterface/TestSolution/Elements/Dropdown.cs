using Aquality.Selenium.Core.Elements;
using Aquality.Selenium.Elements;
using OpenQA.Selenium;

namespace Userinterface.TestSolution.Elements
{
    public class Dropdown : ComboBox
    {
        private By itemDropdown = By.XPath($"//*[@class='dropdown__list-item']");
        public Dropdown(By locator, string name) : base(locator, name, ElementState.ExistsInAnyState)
        {

        }

        public void SelectItem(int index)
        {
            GetElement().FindElements(itemDropdown)[index].Click();
        }

        public int GetCountItem()
        {
            return GetElement().FindElements(itemDropdown).Count();
        }


    }
}
