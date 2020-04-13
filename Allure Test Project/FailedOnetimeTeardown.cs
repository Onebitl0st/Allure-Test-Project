using NUnit.Framework;

namespace Allure_Test_Project
{
    using NUnit.Allure.Core;

    [AllureNUnit]
    public class FailedOnetimeTeardown
    {
        [SetUp]
        public void Setup()
        {
            Assert.Pass();
        }

        [OneTimeTearDown]
        public void Teardown()
        {
            Assert.AreEqual(0, 1);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}