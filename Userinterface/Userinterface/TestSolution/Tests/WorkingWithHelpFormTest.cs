using Userinterface.Tests.Steps.AssertStep;
using Userinterface.Tests.Steps.Step;
using NUnit.Framework;

namespace Userinterface.Tests
{
    public class WorkingWithHelpFormTest: BaseTest
    {
        [Test]
        public void HelpFormIsHiddenTestCase()
        {
            StepsAsserts.AssertIsPresentMainPage();

            StepsTests.ClickHereLink();
            StepsAsserts.AssertIsPresentFirstCardPage();

            StepsTests.ClickSendToBottomButton();
            StepsAsserts.AssertIsNotPresentHelpForm();
        }
    }
}
