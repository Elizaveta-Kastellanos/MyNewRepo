using Userinterface.Framework.Utils;
using Userinterface.Tests.Steps.AssertStep;
using Userinterface.Tests.Steps.Step;
using NUnit.Framework;
using System.Collections;
using Userinterface.TestSolution.Models;

namespace Userinterface.Tests
{
    public class LoginUploadPhotoAndChooseInterestsTest : BaseTest
    {
        /*
        [Test, TestCaseSource(typeof(DataUserModel))]
        public void LoginUploadPhotoAndChooseInterestsTestCase(UserModel userModel)
        {
            StepsAsserts.AssertIsPresentMainPage();

            StepsTests.ClickHereLink();
            StepsAsserts.AssertIsPresentFirstCardPage();

            StepsTests.EnterTextInInput(userModel);
            StepsTests.SelectItemRandomDropdown();
            StepsTests.ClickPrivacyPolicyCheckbox();
            StepsTests.ClickNextButton();
            StepsAsserts.AssertIsPresentSecondCardPage();

            StepsTests.ClickUploadLink();
            StepsTests.UploudFile();
            StepsTests.ClickUnselectAllCheckbox();
            StepsTests.SelectRandomCheckbox();
            StepsTests.ClickNextSecondCardPageButton();
            StepsAsserts.AssertIsPresentThirdCardPage();
        }
        public class DataUserModel : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                var pass = RandomUtils.GetMixedRuEnAndNumText();
                var userModel = new UserModel()
                {
                    Password = pass,
                    Email = RandomUtils.GetRandomTextFromSetText(pass),
                    Domain = RandomUtils.GetRandomEnglishText()
                };
                yield return new object[] { userModel };
            }
        }
        */
        //
    } 
}
