using NUnit.Framework;

namespace Allure_Test_Project
{
    using NUnit.Allure.Core;

    [AllureNUnit]
    public class FailedTeardown
    {
        [SetUp]
        public void Setup()
        {
            Assert.Pass();
        }

        [TearDown]
        public void TearDown()
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