using System;

namespace InventoryAndCharacterLogic
{

    public class ItemType
    {
        public string TypeName {get; internal set;}
        public ItemAmount[] Recipe {get; internal set;}
        public string ResourcePath {get; internal set;}
    }


}
