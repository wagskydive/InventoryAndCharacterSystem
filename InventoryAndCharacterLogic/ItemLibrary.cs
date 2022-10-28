namespace InventoryAndCharacterLogic
{
    public class ItemLibrary
    {
        public ItemType[] AllItemTypes {get;private set;}

        public ItemLibrary(ItemType[] allItemTypes)
        {
            AllItemTypes = allItemTypes;
        }
    }
}