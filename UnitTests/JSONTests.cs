using NUnit.Framework;
using InventoryAndCharacterLogic;


namespace UnitTesting
{
    internal class JSONTests
    {
        [Test]
        public void TestReadFromResources()
        {
            string json = JSONDeserializer.ReadJSON("Resources/TestFileOneString.txt");
            Console.WriteLine(json);
            Assert.AreEqual("One String",json);           
        }

        [Test]
        public void TestJSONReadLibraryName()
        {
            string actualName = "Test Library";

            string testName =  JSONDeserializer.ReadLibraryName("Resources/TestItemLibrary.json");
            Console.WriteLine(testName);
            Assert.AreEqual(actualName,testName);    
        }

        [Test]
        public void TestJSONReadFirstItemTypeName()
        {
            string actualName = "apple";
            ItemLibrary itemLibrary = new ItemLibrary(JSONDeserializer.ReadAllItemTypes("Resources/TestItemLibrary.json"));

            string testName = itemLibrary.AllItemTypes[0].TypeName;
            Console.WriteLine(testName);
            Assert.AreEqual(actualName,testName);    
        }

        [Test]
        public void TestJSONReadFirstItemStackSize()
        {
            int actualSize = 100;
            ItemLibrary itemLibrary = new ItemLibrary(JSONDeserializer.ReadAllItemTypes("Resources/TestItemLibrary.json"));

            int testSize = itemLibrary.AllItemTypes[0].StackSize;
            Console.WriteLine(testSize);
            Assert.AreEqual(actualSize,testSize);    
        }
    }
}