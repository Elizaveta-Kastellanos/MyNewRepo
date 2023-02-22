using Aquality.Selenium.Forms;
using NUnit.Framework;

namespace Userinterface.TestSolution.Pages.Extensions
{
    public static class FormExtensions
    {
        public static void AssertIsPresent(this Form form)
        {
            Assert.IsTrue(form.State.WaitForDisplayed(), $"{form.Name} должны были находиться на странице");
        }

        public static void AssertIsNotPresent(this Form form)
        {
            Assert.IsTrue(form.State.WaitForNotDisplayed(), $"{form.Name} не должны были находиться на странице");
        }
    }
}
