using Userinterface.Tests.Steps.AssertStep;
using Userinterface.Tests.Steps.Step;
using NUnit.Framework;

namespace Userinterface.Tests
{
    public class WorkingWithTimerTest: BaseTest
    {
        [TestCase("00:00:00")]
        public void WhenEnterMainPageTimerShoudBeStartFromZerosTestCase(string timerExpected)
        {
            StepsAsserts.AssertIsPresentMainPage();

            StepsTests.ClickHereLink();
            StepsAsserts.AssertIsPresentFirstCardPage();

            StepsAsserts.AssertIsEqualsTextTimerWithActualTimer(StepsTests.GetTimerText(), timerExpected);
            int aaa = 100;
            //uygyugbuhbuigyuguygyuygvygyvtyftfyugyughuihsdfwfwfwedwdfcsdcwcsdcw
        }
    }
}
