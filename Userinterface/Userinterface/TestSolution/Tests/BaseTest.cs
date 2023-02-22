using Aquality.Selenium.Browsers;
using NUnit.Framework;
using System.Reflection;
using Userinterface.Framework.Utils;
using Userinterface.TestSolution.Models;

namespace Userinterface.Tests
{
    public abstract class BaseTest
    {

        protected readonly Browser browser = AqualityServices.Browser;
        private const string ConfigFilePath = @"Resources\ConfigUtil.json";

        [SetUp]
        public void Setup()
        {
            browser.Maximize();
            browser.GoTo(ConfigUtils<ConfigUtilsModel>.GetConfigDriver($"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\{ConfigFilePath}").MainPageUrl);
            browser.WaitForPageToLoad();
        }

        [TearDown]
        public void ThearDown()
        {
            browser.Quit();
        }
    }
}