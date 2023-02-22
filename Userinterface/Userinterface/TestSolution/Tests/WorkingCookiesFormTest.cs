using Userinterface.Tests.Steps.AssertStep;
using Userinterface.Tests.Steps.Step;
using NUnit.Framework;

namespace Userinterface.Tests
{
    public class WorkingCookiesFormTest: BaseTest
    {
        [Test]
        public void WhenAcceptingCookiesShoudHideCookiesFormTestCase()
        {
            StepsAsserts.AssertIsPresentMainPage();

            StepsTests.ClickHereLink();
            StepsAsserts.AssertIsPresentFirstCardPage();

            StepsTests.ClickNotReallyNoButton();
            StepsAsserts.AssertIsNotPresentCookiesForm();
        }
    }
}
