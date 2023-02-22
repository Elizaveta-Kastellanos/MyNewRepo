using NUnit.Framework;
using Aquality.Selenium.Core.Logging;
using Userinterface.TestSolution.Pages.Extensions;
using Userinterface.TestSolution.Pages;

namespace Userinterface.Tests.Steps.AssertStep
{
    public static class StepsAsserts
    {
        private readonly static LoginPage _firstCardPage = new LoginPage();
        private readonly static UploadPhotoAndIterests _secondCardPage = new UploadPhotoAndIterests();
        private readonly static EnteringPersonalDataPage _thirdCardPage = new EnteringPersonalDataPage();
        private readonly static EntryPage _entryPage = new EntryPage();
        private readonly static HelpForm _helpFprm = new HelpForm();
        private readonly static CookiesForm _cookiesForm = new CookiesForm();

        public static void AssertIsPresentMainPage()
        {
            Logger.Instance.Info("Делаю проверку нахождения на главной странице");
            _entryPage.AssertIsPresent();
        }

        public static void AssertIsPresentFirstCardPage()
        {
            Logger.Instance.Info("Делаю проверку нахождение на странице логирования");
            _firstCardPage.AssertIsPresent();
        }

        public static void AssertIsPresentSecondCardPage() 
        {
            Logger.Instance.Info("Делаю проверку нахождения на странице с загрузкой фото");
            _secondCardPage.AssertIsPresent();
        }

        public static void AssertIsPresentThirdCardPage()
        {
            Logger.Instance.Info("Делаю проверку нахождения на странице с вводом персональных данных");
            _thirdCardPage.AssertIsPresent();
        }

        public static void AssertIsPresentHelpForm()
        {
            Logger.Instance.Info("Делаю проверку появления формы помощи");
            _helpFprm.AssertIsPresent();
        }

        public static void AssertIsNotPresentHelpForm()
        {
            Logger.Instance.Info("Делаю проверку закрытия формы помощи");
            _helpFprm.AssertIsNotPresent();
        }

        public static void AssertIsNotPresentCookiesForm()
        {
            Logger.Instance.Info("Делаю проверку закрытия формы кук");
            _cookiesForm.AssertIsNotPresent();
        }

        public static void AssertIsEqualsTextTimerWithActualTimer(string actual, string expected)
        {
            Logger.Instance.Info("Делаю проверку сравнения времени таймера");
            Assert.AreEqual(expected, actual, $"Актуальное - {actual} и ожидаемое - {expected} время даймера не совпадают");
        }
    }
}
