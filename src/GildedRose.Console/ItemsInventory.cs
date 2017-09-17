using System.Collections.Generic;

namespace GildedRose.Console
{
    public class ItemsInventory
    {
        public IList<Item> Items;
        public void UpdateQuality()
        {            
            foreach (var item in this.Items)
            {
                item.UpdateStatus();
            }
        }        
    }
}