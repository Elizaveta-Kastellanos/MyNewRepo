using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using Userinterface.Framework.Utils;

namespace Userinterface.TestSolution.Pages
{
    public class UploadPhotoAndIterests : Form
    {
        private static readonly By UniqueUploadPhotoPageLocator = By.XPath("//*[contains(@for,'interest_unselectall')]");
        private readonly ILink LinkUpload = ElementFactory.GetLink(By.XPath("//*[contains(@class,'avatar-and-interests__upload-button')]"), "Загрузка картинки");
        private readonly IButton ButtonNext = ElementFactory.GetButton(By.XPath("//*[contains(text(),'Next')]"), "Кнопка Next");
        private ICheckBox UnselectAllCheckbox = ElementFactory.GetCheckBox(By.XPath($"//*[contains(@for,'interest_unselectall')]"), $"Отменить все выбранные чекбоксы");
        private IList<ICheckBox> InterestsСheckboxs() => ElementFactory.FindElements<ICheckBox>(By.XPath("//*[@for!='interest_unselectall' and @for!='interest_selectall']"));

        public UploadPhotoAndIterests() : base(UniqueUploadPhotoPageLocator, "Вторая карточка, загрузка фото и выбор интересов")
        {

        }

        public void ClickUploadLink()
        {
            LinkUpload.Click();
        }

        public void ClickNextButton()
        {
            ButtonNext.Click();
        }

        public void ClickUnselectAllCheckbox()
        {
            UnselectAllCheckbox.Click();
        }

        public void ChooseRandomInterests(int countInterests)
        {
            var copyListInterestsCheckbox = InterestsСheckboxs();
            for (var i = 0; i < countInterests; i++)
            {
                int randomNum = RandomUtils.GetRandomNumber(copyListInterestsCheckbox.Count);
                InterestsСheckboxs()[randomNum].Click();
                copyListInterestsCheckbox.RemoveAt(randomNum);
            }
        }
    }
}
