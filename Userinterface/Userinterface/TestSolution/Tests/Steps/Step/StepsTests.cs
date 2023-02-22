using Aquality.Selenium.Core.Logging;
using Userinterface.Framework.Utils;
using Userinterface.TestSolution.Enums;
using Userinterface.TestSolution.Models;
using Userinterface.TestSolution.Pages;

namespace Userinterface.Tests.Steps.Step
{
    public static class StepsTests
    {
        private readonly static LoginPage _firstCardPage = new LoginPage();
        private readonly static UploadPhotoAndIterests _secondCardPage = new UploadPhotoAndIterests();
        private readonly static EntryPage _entryPage = new EntryPage();
        private readonly static HelpForm _helpFprm = new HelpForm();
        private readonly static CookiesForm _cookiesForm = new CookiesForm();
        private readonly static MainPage _mainPage = new MainPage();
        private const int CountInterests = 3;
        private const string PageImg = @"Resources\kloun.jpg";

        public static void ClickHereLink()
        {
            Logger.Instance.Info("Клик по ссылке HERE, для перехода к первой карточке");
            _entryPage.ClickHereLink();
        }

        public static void EnterTextInInput(UserModel userModel)
        {
            Logger.Instance.Info($"Ввод пароля - {userModel.Password}, ввод email - {userModel.Email}, ввод домена - {userModel.Domain}");
            _firstCardPage.EnterTextInInput(userModel.Password, RegistrationTitleInputEnum.Password);
            _firstCardPage.EnterTextInInput(userModel.Email, RegistrationTitleInputEnum.Email);
            _firstCardPage.EnterTextInInput(userModel.Domain, RegistrationTitleInputEnum.Domain);
        }

        public static void SelectItemRandomDropdown()
        {
            var numberRandom = RandomUtils.GetRandomNumber(_firstCardPage.GetCountItemDomenDropdown());
            Logger.Instance.Info($"Выбор элемента - {numberRandom} из выпадающего списка");
            _firstCardPage.SelectItemDropdown(numberRandom);
        }

        public static void ClickPrivacyPolicyCheckbox()
        {
            Logger.Instance.Info("Клик по чекбоксу - политика конфиденциальности");
            _firstCardPage.ClickPrivacyPolicyCheckbox();
        }

        public static void ClickNextButton()
        {
            Logger.Instance.Info("Клик по кнопке Next");
            _firstCardPage.ClickNextButton();
        }

        public static void ClickUploadLink()
        {
            Logger.Instance.Info("Клик по гипертексту для открытия окна загрузки Windows");
            _secondCardPage.ClickUploadLink();
        }

        public static void ClickUnselectAllCheckbox()
        {
            Logger.Instance.Info($"Отщелкивание всех чекбоксов");
           _secondCardPage.ClickUnselectAllCheckbox();
        }

        public static void SelectRandomCheckbox()
        {
            Logger.Instance.Info($"Рандомный выбор интересов - {CountInterests}");
            _secondCardPage.ChooseRandomInterests(CountInterests);
        }

        public static void ClickNextSecondCardPageButton()
        {
            Logger.Instance.Info("Клик по кнопке Next");
            _secondCardPage.ClickNextButton();
        }

        public static void ClickSendToBottomButton()
        {
            Logger.Instance.Info("Клик по кнопке Send To Bottom, чтобы скрыть форму помощи");
            _helpFprm.ClickSendToBottomButton();
        }

        public static void ClickNotReallyNoButton()
        {
            Logger.Instance.Info("Клик по кнопке Not Really,No, чтобы убрать форму cookies");
            _cookiesForm.ClickNotReallyNoButton();
        }

        public static string GetTimerText()
        {
            Logger.Instance.Info("Получение текста таймера");
           return _mainPage.GetTimerText();
        }

        public static void UploudFile()
        {
            AutoITUtils.UploadFile(PageImg);
        }
    }
}
