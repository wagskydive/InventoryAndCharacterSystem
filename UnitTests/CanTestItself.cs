using NUnit.Framework;
using InventoryAndCharacterLibrary;
using InventoryAndCharacterLogic;


namespace UnitTesting
{
    internal class CanTestItself
    {
        [Test]
        public void TestIfTestRuns()
        {
            bool testToggle;
            testToggle = true;
            Assert.IsTrue(testToggle);
        }
    }
}