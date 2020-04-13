using NUnit.Framework;

namespace Allure_Test_Project
{
    using NUnit.Allure.Core;

    [AllureNUnit]
    public class PassedTest
    {
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void TestWithAttechement()
        {
            TestContext.AddTestAttachment("./res/art.png", "test attachement");

            Assert.AreEqual(1,1);
        }
    }
}