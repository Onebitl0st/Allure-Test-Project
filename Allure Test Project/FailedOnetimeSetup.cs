using NUnit.Framework;

namespace Allure_Test_Project
{
    using NUnit.Allure.Core;

    [AllureNUnit]
    public class FailedOnetimeSetup
    {
        [OneTimeSetUp]
        public void Setup()
        {
            Assert.AreEqual(0,1);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}